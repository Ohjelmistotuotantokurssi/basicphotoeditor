using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace basicphotoeditor
{
    public partial class Form1 : Form
    { 
        private string TAG = "Form1"; //Use tag in debug messages to identify source class

        public Form1()
        {
            InitializeComponent();
            this.Text = Program.ProgramTitle; //Set window title to display app name
        }

        private void onClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }
            else if (button == buttonOpen)
            { 
                Debug.WriteLine(TAG + ": buttonOpen: onClick()");
                openFileDialog();
            }
            else if(button == buttonSave)
            {
                //Show savefile dialog and save the file
                Debug.WriteLine(TAG + ": buttonSave: onClick()");
                //Fetch enabled settings and their values
                ProcessSettings settings = fetchSettings();
                //Open save dialog
                saveFileDialog(settings);
            }
        }

       
        private void openFileDialog()
        {   //This function initializes and opens file picker dialog
            Debug.WriteLine(TAG + ": openFileDialog()");
            this.openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select image file";
            openFileDialog1.Filter = "Image files |*.jpg;*.jpeg;*.png;*.tga;*.gif;*.tif;*.tiff;*.bmp"; //Limit selection to image files
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                Debug.WriteLine(filepath);                
                Program.loadImage(filepath);
                updateUI();
            }
        }
        private void updateUI()
        {
            //Main UI
            setTextBox(Program.getImage().getPath());            

            //Resize
            int x = Program.getImageX();
            int y = Program.getImageY();
            double ratio = Program.getImageAspectRatio();
            string ratioFraction = Program.getImageAspectRatioAsFraction();
            textBoxResizeOrigX.Text = x.ToString();
            textBoxResizeOrigY.Text = y.ToString();
            textBoxResizeNewX.Text = x.ToString();
            textBoxResizeNewY.Text = y.ToString();
            labelResizeOldAspect.Text = ratioFraction;
            labelResizeNewAspect.Text = ratioFraction;

            //Color
            trackBarBrightness.Value = 0;
            trackBarContrast.Value = 0;
            trackBarSaturation.Value = 0;

            //Hue
            trackBarHue.Value = 0;

            //Rotate
            trackBarRotate.Value = 0;            
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Debug.WriteLine(TAG + ": openFileDialog1_FileOk()");
        }

        private void saveFileDialog(ProcessSettings settings)
        {
            this.saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save image file";
            saveFileDialog1.Filter = "JPEG |*.JPG;*.JPEG|BMP|*.BMP;*.RLE|Compuserve GIF|*.GIF|TIFF|*.TIF;*.TIFF|PNG|*.PNG;*.PNS|Targa|*.TGA;*.VDA;*.ICB;*.VSB";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Filename cannot be blank
            {
                Program.saveImage(saveFileDialog1.FileName,settings);
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Debug.WriteLine(TAG + ":saveFileDialog_FileOk()");
        }

        private void setTextBox(string path)
        {
            this.textBoxFilepath.Text = path;
        }

        private ProcessSettings fetchSettings()
        {   //Store user-selected settings and values to ProcessSettings object
            ProcessSettings settings = new ProcessSettings();

            //Filters
            settings.filterGrayscale = checkBoxGrayscale.Checked;    
                    
            //Resize
            try
            {   //Check that new values are valid integers
                int x = int.Parse(textBoxResizeNewX.Text);
                int y = int.Parse(textBoxResizeNewY.Text);
                //Do not allow extremely large images, define maximum X and Y values are in Program.cs
                if (x > Program.MaxX)
                {
                    x = Program.MaxX;
                }
                if(y > Program.MaxY)
                {
                    y = Program.MaxY;
                }
                settings.resizeX = x;
                settings.resizeY = y;
                settings.resizeLockAspect = checkBoxResizeLockAspect.Checked;
                settings.resizeEnable = checkBoxResize.Checked;
            }            
            catch(Exception e)
            {   //If X or Y values are not valid, do not resize
                Debug.WriteLine(TAG + ": " + e.Message);
                //Rollback values
                settings.resizeEnable = false;
                textBoxResizeNewX.Text = Program.getImageX().ToString();
                textBoxResizeNewY.Text = Program.getImageY().ToString();
            }

            //Color
            settings.colorAdjustEnable = checkBoxColour.Checked;
            settings.brightnessValue = trackBarBrightness.Value;
            settings.contrastValue = trackBarContrast.Value;
            settings.saturationValue = trackBarSaturation.Value;

            //Hue
            settings.hueEnable = checkBoxHue.Checked;
            settings.hueValue = 180 + trackBarHue.Value;
            settings.hueRotate = checkBoxHueRotate.Checked;

            //Rotation
            settings.rotateEnable = checkBoxRotate.Checked;
            settings.rotateValue = 180 + trackBarRotate.Value;

            return settings;
        }

        private void textboxTextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox == null)
            {
                return;
            }
            if (textbox == textBoxResizeNewX) { 
                if (checkBoxResizeLockAspect.Checked)
                {   //When aspect ratio is locked, automatically update Y-value to match X-input
                    try
                    {
                        int newX = int.Parse(textbox.Text);
                        double ratio = Program.getImageAspectRatio();
                        textBoxResizeNewY.Text = Math.Round(newX / ratio).ToString();
                    } catch (Exception ex)
                    {
                        Debug.WriteLine(TAG + ": " + ex.Message);
                    }
                    return;
                }
            }
            else if (textbox == textBoxResizeNewY)
            {
                if (checkBoxResizeLockAspect.Checked)
                {   //When aspect ratio is locked, automatically update X-value to match Y-input
                    try
                    {
                        int newY = int.Parse(textbox.Text);
                        double ratio = Program.getImageAspectRatio();
                        textBoxResizeNewX.Text = Math.Round(newY * ratio).ToString();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(TAG + ": " + ex.Message);
                    }
                    return;
                }
            }
            return;
        }

        private void trackBarScroll(object sender, EventArgs e)
        {
            TrackBar trackbar = sender as TrackBar;
            toolTipTrackbarValue.SetToolTip(trackbar, trackbar.Value.ToString());
        }

        private void checkboxMouseHover(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;

            if(checkbox == checkBoxGrayscale)
            {
                toolTipInfo.SetToolTip(checkbox, "Convert image to grayscale");
            }
            else if(checkbox == checkBoxResize)
            {
                toolTipInfo.SetToolTip(checkbox, "Resize image");
            }
            else if (checkbox == checkBoxResizeLockAspect)
            {
                toolTipInfo.SetToolTip(checkbox, "Preserve original aspect ratio");
            }
            else if(checkbox == checkBoxColour)
            {
                toolTipInfo.SetToolTip(checkbox, "Adjust image color");
            }
            else if(checkbox == checkBoxHue)
            {
                toolTipInfo.SetToolTip(checkbox, "Adjust image hue");
            }
            else if(checkbox == checkBoxHueRotate)
            {
                toolTipInfo.SetToolTip(checkbox, "Enable to rotate hue for all colors");
            }
            else if(checkbox == checkBoxRotate)
            {
                toolTipInfo.SetToolTip(checkbox, "Rotate image");
            }

        }

        private void checkboxCheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;

            if(checkbox == checkBoxResizeLockAspect)
            {   //When user locks aspect ratio, reset X and Y to baseline (original) values
                if (checkbox.Checked)
                {
                    textBoxResizeNewX.Text = Program.getImageX().ToString();
                    textBoxResizeNewY.Text = Program.getImageY().ToString();
                }
            }
        }

        private void textBoxMouseHover(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;

            if(textbox == textBoxResizeNewX)
            {
                toolTipInfo.SetToolTip(textbox, "1...8000");
            }
            else if(textbox == textBoxResizeNewY){
                toolTipInfo.SetToolTip(textbox, "1...8000");
            }
        }
    }
}

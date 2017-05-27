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
                initializeUI();
            }
        }
        private void initializeUI()
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

            //TODO: Initialize rest of the UI as functions are added
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
                settings.resizeX = int.Parse(textBoxResizeNewX.Text);
                settings.resizeY = int.Parse(textBoxResizeNewY.Text);
                settings.resizeLockAspect = checkBoxResizeLockAspect.Checked;
                settings.resizeEnable = checkBoxResize.Checked;
            }            
            catch(Exception e)
            {   //If X or Y values are not valid, do not resize
                Debug.WriteLine(TAG + ": " + e.Message);
                settings.resizeEnable = false;
            }  
            return settings;
        }

        private void textboxTextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if(textbox != null)
            {
                if(textbox == textBoxResizeNewX)
                {
                    //TODO: Implement functionality where NewY is automatically calculated based on NewX input if lock aspect ratio is enabled
                    return;
                }
                if(textbox == textBoxResizeNewY)
                {
                    //TODO: Implement functionality where NewX is automatically calculated based on NewY input if lock aspect ratio is enabled
                    return;
                }
            }
            return;
        }
    }
}

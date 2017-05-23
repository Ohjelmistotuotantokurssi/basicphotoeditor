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
                saveFileDialog();
            }
        }

        //This function initializes and opens file picker dialog
        private void openFileDialog()
        {
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
                setTextBox(filepath);
                Program.loadImage(filepath);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Debug.WriteLine(TAG + ": openFileDialog1_FileOk()");
        }

        private void saveFileDialog()
        {
            this.saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save image file";
            saveFileDialog1.Filter = "Jpeg image|*.jpg|Bitmap image|*.bmp|Gif image|.gif";
           // saveFileDialog1.ShowDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Filename cannot be blank
            {
                Program.saveImage(saveFileDialog1.FileName);
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

        private void onCheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if(checkBox == null)
            {
                return;
            }
            else if(checkBox == checkBoxGrayscaleToggle)
            {
                Program.toggleEffect(mImageProcessor.GREYSCALE, checkBox.Checked);
            }

        }


    }
}

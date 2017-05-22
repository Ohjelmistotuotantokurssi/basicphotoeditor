using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicphotoeditor
{   
    public partial class Form1 : Form
    { 
        private string TAG; //Use tag in debug messages to identify source class

        public Form1()
        {
            InitializeComponent();
            TAG = GetType().Name;        
        }

        private void onClick(object sender, EventArgs e)
        {            
            Debug.WriteLine(TAG + ": onClick()");

            openFileDialog();
        }

        //This function initializes and opens file picker dialog
        private void openFileDialog()
        {
           Debug.WriteLine(TAG + ": openFileDialog()");

            this.openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select image file";
            openFileDialog1.Filter = "Image files |*.jpg;*.png;*.tga;*.gif;*.tif;*.tiff"; //Limit selection to image files
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                Debug.WriteLine(filepath);
                setTextBox(filepath);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Debug.WriteLine(TAG + ": openFileDialog1_FileOk()");
        }

        private void setTextBox(string filepath)
        {
            this.textBox1.Text = filepath;
        }
    }
}

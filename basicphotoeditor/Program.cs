using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicphotoeditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        
        public static void MergeImages()
        {
            //Initialize mImageProcessor helper class that is used for operation
            mImageProcessor imageProcessor = new mImageProcessor();

            //Method calls for three files; inpu1, input2 and output
            string inputa = @"<path for first file>";
            string inputb = @"<path for second file";
            string output = @"<path where output file will be saved>";

            //Call MergeImages method from helper class
            imageProcessor.MergeImages(inputa, inputb, output);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private static mImage image = new mImage();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void loadImage(string filepath)
        {
            image.setPath(filepath);
        }
        
        public static void mergeImages()
        {
            // EXAMPLE:
            //
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

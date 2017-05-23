using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        private static string TAG = "Program";
        private static mImage image = new mImage();

        public static bool greyScaleEnabled { get; set; }
        public static bool resizeEnabled { get; set; }

        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void saveImage(string path)
        {
            mImageProcessor imageProcessor = new mImageProcessor();
            byte[] imageBytes = image.getByteArray();
            byte[] outputBytes = null;            

            if (greyScaleEnabled)
            {
                outputBytes = imageProcessor.toGreyScale(imageBytes);
            }
            if (resizeEnabled)
            {
                //Add resize function here
            }

            if(outputBytes != null)
            {
                writeFile(outputBytes, path);
               
            }
        }

        public static void writeFile(byte[] outputBytes, string path)
        {
            File.WriteAllBytes(path, outputBytes);
            if (!File.Exists(path))
            {
                Debug.WriteLine(TAG + ": ERROR: writeFile(): File not saved");
            }
        }

        public static void loadImage(string filepath)
        {
            image.setPath(filepath);
        }

        public static void toggleEffect(int effect, bool value)
        {
            switch (effect)
            {
                case mImageProcessor.GREYSCALE:
                    greyScaleEnabled = value;
                    return;
                case mImageProcessor.RESIZE:
                    resizeEnabled = value;
                    return;
                default:
                    return;
            }
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

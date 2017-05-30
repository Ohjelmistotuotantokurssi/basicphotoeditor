using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace basicphotoeditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static string TAG = "Program";
        private static string filepath;
        private static mImageProcessor imageProcessor;
        private static mImage image;
        private static byte[] imageBytes = null;
        private static byte[] outputBytes = null;

        public const string ProgramTitle = "Basic Photo Editor";
        public const int MinX = 2;
        public const int MinY = 2;
        public const int MaxX = 8000;
        public const int MaxY = 8000;

        public static bool greyScaleEnabled { get; set; }
        public static bool resizeEnabled { get; set; }
        public static int xSize { get; set; }
        public static int ySize { get; set; }
        public static bool lockedAspect { get; set; }

        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void saveImage(string path,ProcessSettings settings)
        {
            if (!image.fileExists())
            {
                return;
            }
            imageProcessor = new mImageProcessor();
            imageBytes = image.getByteArray();
            outputBytes = imageBytes;        

            if (settings.filterGrayscale)
            {
                outputBytes = imageProcessor.toGreyScale(outputBytes);
            }
            if (settings.colorAdjustEnable)
            {
                outputBytes = imageProcessor.adjustColor(outputBytes, settings.brightnessValue,settings.contrastValue,settings.saturationValue);
            }
            if (settings.hueEnable)
            {
                outputBytes = imageProcessor.adjustHue(outputBytes, settings.hueValue, settings.hueRotate);
            }
            if (settings.rotateEnable)
            {
                outputBytes = imageProcessor.rotateImage(outputBytes, settings.rotateValue);
            }
            if (settings.resizeEnable)
            {   //Resize needs to be done last for best image quality
                outputBytes = imageProcessor.resize(outputBytes, settings.resizeX, settings.resizeY, settings.resizeLockAspect);
            }
            if(outputBytes != null)
            {
                writeFile(outputBytes, path); //save to file
                //clear byte arrays to free up memory
                imageBytes = null;
                outputBytes = null;  
            }
        }

        public static void writeFile(byte[] output, string path)
        {
            //Use FileStream rather than File for better memory management with extremely large image files
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
                fs.Write(output, 0, output.Length);    
                fs.Close();
            }
            if (!File.Exists(path))
            {
                Debug.WriteLine(TAG + ": ERROR: writeFile(): File not saved");
            }            
        }
        public static void setImagePath(string newPath)
        {
            filepath = newPath;
        }

        public static mImage Image()
        {
            image = new mImage(filepath);
            return image;
        }

        public static int getImageX()
        {
            if (!image.fileExists())
            {
                return 0;
            }
            return image.getImage().Width;
        }

        public static int getImageY()
        {
            if (!image.fileExists())
            {
                return 0;
            }
            return image.getImage().Height;
        }

        public static double getImageAspectRatio()
        {
            if (!image.fileExists())
            {
                return 1F;
            }
            double ratio = (double)image.getImage().Width / (double)image.getImage().Height;
            return ratio;
        }

        public static string getImageAspectRatioAsFraction()
        {
            double ratio = getImageAspectRatio();
            mMath math = new mMath();
            Fraction fraction = math.RealToFraction(ratio, 0.01);
            return fraction.N.ToString() + ":" + fraction.D.ToString();
        }
        public static string getImageAspectRatioAsFraction(int x, int y)
        {
            double ratio = (double)x / (double)y;
            mMath math = new mMath();
            Fraction fraction = math.RealToFraction(ratio, 0.01);
            return fraction.N.ToString() + ":" + fraction.D.ToString();
        }
        public static void showMessageBox(string message)
        {
            MessageBox.Show(message);
        }
    }
}

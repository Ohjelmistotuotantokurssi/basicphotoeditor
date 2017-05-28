﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
            mImageProcessor imageProcessor = new mImageProcessor();
            byte[] imageBytes = image.getByteArray();
            byte[] tempBytes = imageBytes;
            byte[] outputBytes = null;          

            if (settings.filterGrayscale)
            {
                tempBytes = imageProcessor.toGreyScale(tempBytes);
            }
            if (settings.colorAdjustEnable)
            {
                tempBytes = imageProcessor.adjustColor(tempBytes,settings.brightnessValue,settings.contrastValue,settings.saturationValue);
            }
            if (settings.resizeEnable)
            {   //Image resize should be done last to maintain best quality
                tempBytes = imageProcessor.resize(tempBytes, settings.resizeX, settings.resizeY, settings.resizeLockAspect);
            }
            
            outputBytes = tempBytes;
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

        public static mImage getImage()
        {
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
    }
}

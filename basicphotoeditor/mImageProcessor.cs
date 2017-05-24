using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using ImageProcessor.Imaging;
using ImageProcessor;
using System.Diagnostics;
using ImageProcessor.Imaging.Filters.Photo;

namespace basicphotoeditor
{
    /*
    * mImageProcessor
    * 
    * This class provides interface for image processing tasks, utilizing ImageProcessor library
    * 
    * Implements following functionalities:
    * Greyscale
    * 
    * TODO:
    * Brightness
    * Contrast
    * Saturation
    * Hue
    * Resize
    * Rotate
    *  
    * 10.5.2017 - Created by Samuli Kumo
    */

    class mImageProcessor
    {
        //Setting IDs
        public const int GREYSCALE = 1;
        public const int RESIZE = 2;
        public const int BRIGHTNESS = 3;
        public const int CONTRAST = 4;
        public const int SATURATION = 5;
        public const int HUE = 6;
        public const int ROTATE = 7;
        public const int LOCKEDASPECT = 8;

        //Converts image bytearray to greyscale bytearray
        public byte[] toGreyScale(byte[] imageBytes)
        {
            byte[] output;
            using(MemoryStream inStream = new MemoryStream(imageBytes))
            {
                using(MemoryStream outStream = new MemoryStream())
                {
                    using(ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        imageFactory
                            .Load(inStream)
                            .Filter(MatrixFilters.GreyScale)
                            .Save(outStream)
                            .Dispose();
                    }
                    outStream.Position = 0;
                    output = outStream.ToArray();
                }
            }
            return output;
        }
                
    }


}

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
        //Converts image bytearray to greyscale bytearray
        public byte[] toGreyScale(byte[] imageBytes)
        {
            byte[] output;
            using(MemoryStream inStream = new MemoryStream(imageBytes))
            {
                using(MemoryStream outStream = new MemoryStream())
                {
                    using(ImageFactory imageFactory = new ImageFactory())
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

        //Resize image
        public byte[] resize(byte[] imagebytes, int x, int y, bool lockAspect)
        {
            byte[] output;
            using(MemoryStream inStream = new MemoryStream(imagebytes))
            {
                using(MemoryStream outStream = new MemoryStream())
                {
                    using (ImageFactory imageFactory = new ImageFactory())
                    {
                        if (lockAspect)
                        {
                            //Image is cropped to fit new dimensions while maintaining aspect ratio
                            imageFactory
                                .Load(inStream)
                                .Resize(new ResizeLayer(new Size(x,y),ResizeMode.Max,AnchorPosition.Center,true))
                                .Save(outStream)
                                .Dispose();
                        }else
                        {
                            //If aspect ratio is not locked, image will be stretched to fit new dimensions
                            imageFactory
                                .Load(inStream)
                                .Resize(new ResizeLayer(new Size(x, y), ResizeMode.Stretch, AnchorPosition.Center,true))
                                .Save(outStream)
                                .Dispose();
                        }
                    }
                    outStream.Position = 0;
                    output = outStream.ToArray();
                }
            }
            return output;

        }

        public byte[] adjustColor(byte[] imageBytes, int brightness, int contrast, int saturation)
        {
            byte[] output;
            using(MemoryStream inStream = new MemoryStream(imageBytes))
            {
                using(MemoryStream outStream = new MemoryStream())
                {
                    using(ImageFactory imageFactory = new ImageFactory())
                    {
                        imageFactory
                            .Load(inStream)
                            .Brightness(brightness)
                            .Contrast(contrast)
                            .Saturation(saturation)
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

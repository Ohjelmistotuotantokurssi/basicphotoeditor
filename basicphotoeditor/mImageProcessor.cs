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

namespace basicphotoeditor
{
    //
    // This class provides interface for image processing tasks, utilizing ImageProcessor library
    //

    class mImageProcessor
    {
        //Merges two bytearrays together and returns combined array
        public bool MergeImages(string filepath1, string filepath2, string outputpath)
        {
            //First, check that inputfiles exist
            if (!File.Exists(filepath1) || !File.Exists(filepath2))
            {
                Debug.WriteLine("File not found, operation cancelled");
                return false;
            }
            else
            {
                //Store base image into byte array
                byte[] imga = File.ReadAllBytes(filepath1);

                //Create Image object for the image to be layered on top, which is passed to ImageLayer object
                Image imgb = Image.FromFile(filepath2);
                ImageLayer layer = new ImageLayer();
                layer.Image = imgb;

                //Initialize memorystream by placing base image into it
                MemoryStream inStream = new MemoryStream(imga);
                using (MemoryStream outStream = new MemoryStream())
                {
                    //ImageFactory handles image processing tasks
                    using (ImageFactory imageFactory = new ImageFactory())
                    {
                        imageFactory
                            .Load(inStream)
                            .Overlay(layer)
                            .Save(outStream);
                        imageFactory.Dispose(); //Remember to dispose Imagefactory object!
                    }
                    //Move Memorystream pointer back to beginning and write the contents to file
                    outStream.Position = 0;
                    File.WriteAllBytes(outputpath, outStream.ToArray());

                    //Verify that file was created
                    if (File.Exists(outputpath))
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicphotoeditor
{
    class mImage 
    {
        /* 
         * mImage
         * 
         * Helper class for handling image file
         * 
         * 22.5.2017 - Created by Samuli Kumo 
         */

        private string filepath;
        private bool fileExist;

        public mImage(string path)
        {        
            if (File.Exists(path))
            {
                try
                {
                    this.filepath = path;
                    this.fileExist = true;
                }
                catch (FileNotFoundException)
                {
                    Program.showMessageBox("File not found!");
                }
                catch (OutOfMemoryException)
                {
                    Program.showMessageBox("Selected image is too large!");
                }
                catch (ArgumentException)
                {
                    Program.showMessageBox("Failed to open image!");
                }
            }
        }
        public bool fileExists()
        {
            return this.fileExist;
        }
        public string getPath()
        {
            return this.filepath;
        }
        public string getFilename()
        {
            return Path.GetFileName(getPath());
        }
        public string getDirectory()
        {
            return Path.GetDirectoryName(getPath());
        }
        public string getFileExtension()
        {
            return Path.GetExtension(getPath());
        }
        public Image getImage()
        {
            using (FileStream fs = new FileStream(getPath(), FileMode.Open, FileAccess.Read))
            {
                Image image = Image.FromStream(fs);
                return image;
            }                     
        }
        public byte[] getByteArray()
        {
            return File.ReadAllBytes(getPath());                         
        }
    }
}

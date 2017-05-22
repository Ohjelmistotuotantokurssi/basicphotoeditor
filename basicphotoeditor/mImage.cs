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

        public void setPath(string filepath)
        {
            this.filepath = filepath;
        }
        public bool fileExists()
        {
            return File.Exists(getPath());
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
            return Image.FromFile(getPath());
        }
        public byte[] getByteArray()
        {
            return File.ReadAllBytes(getPath());
        }
    }
}

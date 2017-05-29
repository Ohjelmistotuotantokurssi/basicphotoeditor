
namespace basicphotoeditor
{
    struct ProcessSettings
    {
        /*
         * ProcessSettings 
         * Use this structure to store and pass processing settings from UI to image processing
         */
        public bool filterGrayscale { get; set; }
        public bool resizeEnable { get; set; }
        public int resizeX { get; set; }
        public int resizeY { get; set; }
        public bool resizeLockAspect { get; set; }
        public bool colorAdjustEnable { get; set; }
        public int brightnessValue { get; set; }
        public int contrastValue { get; set; }
        public int saturationValue { get; set; }
        public bool hueEnable { get; set; }
        public int hueValue { get; set; }
        public bool hueRotate { get; set; }
        public bool rotateEnable { get; set; }
        public int rotateValue { get; set; }
    }
}

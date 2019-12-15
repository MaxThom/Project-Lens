using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Unsplash
{
    public class Exif
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string ExposureTime { get; set; }
        public string Aperture { get; set; }
        public string FocalLength { get; set; }
        public int Iso { get; set; }
    }
}
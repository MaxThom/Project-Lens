﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Unsplash
{
    public class Location
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Position Position { get; set; }
    }
}
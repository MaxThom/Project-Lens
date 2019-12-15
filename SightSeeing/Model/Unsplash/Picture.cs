using Model.Unsplash;
using System;
using System.Collections.Generic;

namespace Model.Unsplash
{
    public class Picture
    {
        public string id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime promoted_at { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string color { get; set; }
        public string description { get; set; }
        public string alt_description { get; set; }
        public Urls urls { get; set; }
        public Links links { get; set; }
        public List<object> categories { get; set; }
        public int likes { get; set; }
        public bool liked_by_user { get; set; }
        public List<object> current_user_collections { get; set; }
        public User user { get; set; }
        public Exif exif { get; set; }
        public Location location { get; set; }
        public int views { get; set; }
        public int downloads { get; set; }
    }
}
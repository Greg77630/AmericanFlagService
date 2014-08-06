using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmericanFlagServiceManager.Models
{
    public class Location
    {
        public string Name { get; set; }
        public Coordinate Coord { get; set; }
        public string Image { get; set; }
    }
}
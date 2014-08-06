using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmericanFlagServiceManager.Models
{
    public class Map
    {   
        public string Name { get; set; }
        public Coordinate Coord { get; set; }
        public int Zoom { get; set; }

        private List<Location> locations = new List<Location>();

        public List<Location> Locations
        {
            get { return locations; }
            set { locations = value; }
        }
    }
}
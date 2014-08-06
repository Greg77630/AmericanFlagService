using AmericanFlagServiceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml.Linq;

namespace AmericanFlagServiceManager.Repositories
{
    public class MapRepository
    {
        ApplicationDbContext dbcontext = new ApplicationDbContext();
        public Map GetByContactId(int contactId)
        {
            var contact = dbcontext.Contact.FirstOrDefault(c => c.ContactId == contactId);
            return new Map 
            { 
                Name = contact.Name,
                Zoom = 18,
                Coord = new Coordinate { Latitude = 0.0, Longitude = 0.0, },
                Locations = { new Location 
                                    {
                                        Name = contact.Name,
                                        Coord = GetCoordFromAddress(contact.Address,contact.City,contact.State,contact.Zip)
                                    }
                },
            };
        }

        private Coordinate GetCoordFromAddress(string addr, string city, string state, string zip)
        {
            var key = "AIzaSyA5ON0IbXD7JbDQC9TF6SzsiQvGKd3hNIw";
            var address = addr + " " + city + " " + state + " " + zip;
            var requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false", Uri.EscapeDataString(address), Uri.EscapeDataString(key));

            var request = WebRequest.Create(requestUri);
            var response = request.GetResponse();
            var xdoc = XDocument.Load(response.GetResponseStream());

            var result = xdoc.Element("GeocodeResponse").Element("result");
            var locationElement = result.Element("geometry").Element("location");
            var lat = locationElement.Element("lat");
            var lng = locationElement.Element("lng");

            return new Coordinate { Latitude = (double)lat, Longitude = (double)lng };// { lat, lng, };
        }
    }
}
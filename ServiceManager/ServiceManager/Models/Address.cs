using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceManager.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public string StreetLine3 { get; set; }

        public string City { get; set; }

        public State State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
    }
}

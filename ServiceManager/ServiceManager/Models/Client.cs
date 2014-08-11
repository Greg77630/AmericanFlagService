﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceManager.Models
{
    public class Client
    {
        public string Name { get; set; }
        public virtual List<Address> ClientLocations { get; set; }

        public Contact PrimaryContact { get; set; }

        public Address BillingAddress { get; set; }
    }
}
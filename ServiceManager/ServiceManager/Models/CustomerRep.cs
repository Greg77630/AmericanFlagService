using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceManager.Models
{
    public class CustomerRep
    {
        public int RepId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<PhoneNumber> PhoneNumbers { get; set; }
        public string EmailAddress { get; set; }
    }
}

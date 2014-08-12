using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<PhoneNumber> PhoneNumbers { get; set; }
        public string EmailAddress { get; set; }
    }
}

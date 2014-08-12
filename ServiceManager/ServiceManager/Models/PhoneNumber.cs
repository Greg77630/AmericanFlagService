using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceManager.Models
{
    public class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public string AreaCode { get; set; }

        public string Number { get; set; }

        public PhoneType Type { get; set; }
    }
}

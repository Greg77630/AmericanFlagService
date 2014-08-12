using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceManager.Models
{
    public class PhoneNumber
    {
        public string AreaCode { get; set; }

        public string Number { get; set; }

        public PhoneType Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ServiceManager.Models
{
    public enum PhoneType
    {
        [Description("Home")]
        Home,
        [Description("Work")]
        Work,
        [Description("Mobile")]
        Mobile
    }
}

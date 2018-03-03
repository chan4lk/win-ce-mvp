using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceProject1.Models
{
    public class Person : IModel
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SmartDeviceProject1.Models;

namespace SmartDeviceProject1.Views
{
    public interface IPersonView
    {
        Person Model { get; set; }

        void BindModel();
    }
}

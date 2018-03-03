using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SmartDeviceProject1.Views;

namespace SmartDeviceProject1.Presenters
{
    public interface IPersonPresenter
    {
        IPersonView View { get; set; }
        void Initialize(IPersonView view);
        void LoadPersonDetails();

    }
}

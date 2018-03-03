using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceProject1.Commands
{
    public interface ICommand<T>
    {
        T Result { get; }
        void Execute();
    }
}

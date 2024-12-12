using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10_Task2_HW
{
    internal interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}

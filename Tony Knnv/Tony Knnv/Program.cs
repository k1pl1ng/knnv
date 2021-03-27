using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Tony_Knnv
{
    class Program
    {
        static void Main()
        {
            Registry.CurrentUser.CreateSubKey(@"Software\my project").SetValue("parameter", 1);
        }
    }
}
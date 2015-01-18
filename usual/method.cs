using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EasyMcLauncher
{
    class method
    {
        public static void delay(int time)
        {
            Thread t= new Thread(o => Thread.Sleep(time));
            t.Start();
            while (t.IsAlive)
            {
                Application.DoEvents();
            }
        }
    }
}

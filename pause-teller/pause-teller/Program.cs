using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using pause_teller;

namespace Pause_teller
{
    unsafe class Exe
    {
        public static void Main()
        {
            Teller teller = new Teller();
            Aanuit aanuit = new Aanuit();
            bool run = true;
            Boolean tel = true;
            int timer = 0;
            long millisecondsjesus = DateTime.Now.Ticks;
            while (run == true)
            {
                long millisecondsjesus2 = DateTime.Now.Ticks;
                long ticks = millisecondsjesus2 - millisecondsjesus;
                tel = aanuit.Switch(tel);
                if (tel == true)
                {
                    timer = teller.Tel(timer, ticks);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Pause_teller;

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
            bool telop = true;
            int timer = 0;
            long millisecondsjesus = DateTime.Now.Ticks;
            long seconds = 0;
            long lastseconds = 0;
            while (run == true)
            {
                tel = aanuit.Switch(tel);
                if (tel == true)
                {
                    seconds = teller.Tel_op(seconds, millisecondsjesus, lastseconds, telop);
                    if (seconds != lastseconds)
                    {
                        timer++;
                        Console.WriteLine(timer);
                    }
                    lastseconds = seconds;
                }
            }
        }
    }
}
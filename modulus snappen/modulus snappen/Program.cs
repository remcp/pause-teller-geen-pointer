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
            int timer = 0;
            long millisecondsjesus = DateTime.Now.Ticks;
            long lastseconds = 0;
            while (run == true)
            {
                long millisecondsjesus2 = DateTime.Now.Ticks;
                long ticks = millisecondsjesus2 - millisecondsjesus;
                tel = aanuit.Switch(tel);
                if (tel == true)
                {
                    long seconds = ticks / TimeSpan.TicksPerSecond;
                    if(seconds != lastseconds)
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
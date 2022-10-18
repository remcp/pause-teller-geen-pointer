using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pause_teller
{
    unsafe class Teller
    {
        public int Tel(int timer, long ticks)
        {
            long seconds = ticks / TimeSpan.TicksPerSecond;
            if (seconds % 1 == 0)
            {
                timer++;
                Console.WriteLine(timer);
            }

            return timer;
        }
    }
}
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
        public long Tel_op(long seconds, long millisecondsjesus, long lastseconds, bool telop)
        {
            long millisecondsjesus2 = DateTime.Now.Ticks;
            long ticks = millisecondsjesus2 - millisecondsjesus;
            seconds = ticks / TimeSpan.TicksPerSecond;
            return seconds;
        }
    }
}
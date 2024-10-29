using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz
{
    class TimeManager
    {
        private Stopwatch Watch;
        private long TimeStampsStart;
        public TimeManager() 
        {
            Watch = new Stopwatch();
            Watch.Start();
            TimeStampsStart = Watch.ElapsedMilliseconds;
        }
    }
}

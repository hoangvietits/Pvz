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
        private long secfps;
        private int last_fps = 0;
        private int countfps = 0;
        private long last_time = 0;
        public TimeManager() 
        {
            Watch = new Stopwatch();
            Watch.Start();
            TimeStampsStart = Watch.ElapsedMilliseconds;
        }

        public void PaintFinished()
        {
            long T = Watch.ElapsedMilliseconds;
            if(T / 1000 == secfps)
            {
                countfps++;
            }
            else
            {
                last_fps = countfps;
                countfps = 1;
                secfps++;
            }
        }

        public double GetDeltaTime()
        {
            long nt = Watch.ElapsedMilliseconds;
            double deltaT = (nt - last_time);
            last_time = nt;
            return deltaT;
        }
    }
}

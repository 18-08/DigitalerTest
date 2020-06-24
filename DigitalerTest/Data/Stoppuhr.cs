using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace DigitalerTest.Data
{
    public class Stoppuhr
    {
        public Timer timer;

        public void starteStoppuhr()
        {
            timer = new Timer();  

            timer.Interval = 10000;

            timer.Start();
        }

        public void stoppeStoppuhr()
        {
            timer.Stop();
        }
    }
}

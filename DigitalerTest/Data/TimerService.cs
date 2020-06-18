using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace DigitalerTest.Data
{
    public class TimerService
    {
        private Timer timer;

        public void SetzeTimer(double zeitraum)
        {
            timer = new Timer(zeitraum);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
            timer.Start();
        }

        public event Action OnElapsed;
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            OnElapsed?.Invoke();
            timer.Dispose();
        }
    }
}

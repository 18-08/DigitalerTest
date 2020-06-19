using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalerTest.Data
{
    public class StoppuhrService
    {
        public Task<Stoppuhr> starteStoppuhrAsync()
        {
            Stoppuhr stoppuhr = new Stoppuhr();

            stoppuhr.starteStoppuhr();

            return Task.FromResult(stoppuhr);
        }
    }
}

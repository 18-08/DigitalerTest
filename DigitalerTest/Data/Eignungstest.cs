using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalerTest.Data
{
    public class Eignungstest
    {
        public string identifier { get; set; }

        public List<Themengebiete> themengebiete = new List<Themengebiete>();
    }
}

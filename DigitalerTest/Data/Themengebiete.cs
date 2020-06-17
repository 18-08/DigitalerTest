using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalerTest.Data
{
    public class Themengebiete
    {
        public string titel { get; set; }
        public List<Frage> fragen = new List<Frage>();
    }
}

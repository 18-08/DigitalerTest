using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalerTest.Data
{
    public class IdentifikationsNr
    {
        [Required]
        [RegularExpression(^"[0-9]")]
        
       
        public string IDNummer { get; set; }
    }
}

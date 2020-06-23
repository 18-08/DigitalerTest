using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DigitalerTest;

namespace DigitalerTest.Data
{
    public class IdentifikationsNr
    {
        [Required]
        [RegularExpression("[0-9]{7,7}", ErrorMessage = "Bitte überprüfen Sie ihre Identifikationsnummer!")]
        
        public string IDNummer { get; set; }

        public Expression<Func<IdentifikationsNr>> For { get; set; }
    }
}

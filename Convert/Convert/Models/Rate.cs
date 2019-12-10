using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Convert.Models
{
    public class Rate
    {
        public Dictionary<string, double> Rates { get; set; }
        public string Base { get; set; }
        public string Date { get; set; }
    }
}

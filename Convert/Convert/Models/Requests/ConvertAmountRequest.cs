using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Convert.Models.Requests
{
    public class ConvertAmountRequest
    {
        public double Amount { get; set; }
        public string BaseCurrency { get; set; }
        public string TargetCurrency { get; set; }
    }
}

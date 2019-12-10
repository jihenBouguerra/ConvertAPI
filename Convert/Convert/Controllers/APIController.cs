using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Convert.Models.Responses;
using Convert.Models.Requests;
using Convert.Models;

namespace Convert.Controllers
{
    [Route("api")]
    [ApiController]
    public class APIController : ControllerBase
    {
        [HttpPost("convertAmount")]
        public ConvertAmountResponse ConvertAmount (ConvertAmountRequest convertRequest)
        {
            double rate = ExchangeRatesApi.GetRate(convertRequest.BaseCurrency,convertRequest.TargetCurrency);
            var value = convertRequest.Amount * rate;
            ConvertAmountResponse response = new ConvertAmountResponse { Value = value };

            return response;

        }

        

    }
}

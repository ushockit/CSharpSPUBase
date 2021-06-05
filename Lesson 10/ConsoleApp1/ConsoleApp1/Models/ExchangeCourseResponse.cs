using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ExchangeCourseResponse
    {
        [JsonProperty("ccy")]
        public string Currency { get; set; }

        [JsonProperty("base_ccy")]
        public string BaseCurrency { get; set; }

        public decimal Buy { get; set; }
        public decimal Sale { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.FlotCharts.Model
{
    public class MarkingsAxis
    {
        [JsonProperty(PropertyName = "from")]
        public double? From { get; set; }

        [JsonProperty(PropertyName="to")]
        public double? To { get; set; }
    }
}

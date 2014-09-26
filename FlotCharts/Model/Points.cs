using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    public class Points : BaseType
    {
        /// <summary>
        /// Null or Number
        /// </summary>
        [JsonProperty(PropertyName = "radius")]
        public double? Radius { get; set; }
    }
}

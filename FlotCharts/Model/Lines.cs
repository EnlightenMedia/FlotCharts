using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    public class Lines : BaseType
    {

        /// <summary>
        /// Null or Boolean
        /// </summary>
        [JsonProperty(PropertyName = "steps")]
        public bool? Steps { get; set; }
    }
}

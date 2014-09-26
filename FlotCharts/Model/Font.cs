using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.FlotCharts.Model
{
    public class Font
    {
        /// <summary>
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "lineHeight")]
        public int? LineHeight { get; set; }

        /// <summary>
        /// string
        /// </summary>
        [JsonProperty(PropertyName = "style")]
        public string Style { get; set; }

        /// <summary>
        /// string
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public string Weight { get; set; }

        /// <summary>
        /// string
        /// </summary>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// string
        /// </summary>
        [JsonProperty(PropertyName = "variant")]
        public string Variant { get; set; }

        /// <summary>
        /// string
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

    }
}

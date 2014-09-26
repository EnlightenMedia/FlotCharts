using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Bars : BaseType
    {

        /// <summary>
        /// Allows extra options to be added for plugins
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> ExtensionOptions = new Dictionary<string, object>();

        /// <summary>
        /// Null or Double
        /// </summary>
        [JsonProperty(PropertyName = "numbers")]
        BarsNumbers numbers;
        public BarsNumbers Numbers
        {
            get
            {
                if (numbers == null)
                    numbers = new BarsNumbers();
                return numbers;
            }
            set
            {
                numbers = value;
            }
        }

        /// <summary>
        /// Null or Double
        /// </summary>
        [JsonProperty(PropertyName = "barWidth")]
        public double? BarWidth { get; set; }

        /// <summary>
        /// Null or Number
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public int? Order { get; set; }

        
        /// <summary>
        /// "left", "right" or "center"
        /// </summary>
        [JsonProperty(PropertyName = "align")]
        public string Align { get; set; }
                
        /// <summary>
        /// Null or Double
        /// </summary>
        [JsonProperty(PropertyName = "horizontal")]
        public bool? Horizontal { get; set; }
    }
}

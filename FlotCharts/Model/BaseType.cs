using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.FlotCharts.Model
{
    public class BaseType
    {
        /// <summary>
        /// Null or Boolean
        /// </summary>
        [JsonProperty(PropertyName="show") ]
        public bool? Show { get; set; }

        /// <summary>
        /// Null or Number
        /// </summary>
        [JsonProperty(PropertyName="lineWidth") ]
        public int? LineWidth { get; set; }
        
        /// <summary>
        /// Null or Boolean
        /// </summary>
        [JsonProperty(PropertyName="fill") ]
        object fill { get; set; }
                
        /// <summary>
        /// null or color/gradient
        /// </summary>
        [JsonProperty(PropertyName="fillColor") ]
        public string FillColor { get; set; }


        public BaseType SetFill(object input) 
        {
            fill = input;
            return this;
        }
    }
}

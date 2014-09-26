using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Legend : ICloneable
    {
        /// <summary>
        /// Null or True/False
        /// </summary>
        [JsonProperty(PropertyName = "show")]
        public bool? Show { get; set; }        
    
        /// <summary>
        /// Null or (fn: string, series object -> string)
        /// </summary>
        [JsonProperty(PropertyName = "labelFormatter")]
        public string LabelFormatter { get; set; }   

    
        /// <summary>
        /// color 
        /// </summary>
        [JsonProperty(PropertyName = "labelBoxBorderColor")]
        public string LabelBoxBorderColor { get; set; }   
    
        /// <summary>
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "noColumns")]
        public int? NumberOfColumns  { get; set; }   
    
        /// <summary>
        ///  "ne" or "nw" or "se" or "sw"
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set;}
    
        /// <summary>
        /// Number of pixels or [x margin, y margin]
        /// </summary>
        [JsonProperty(PropertyName = "margin")]
        public object Margin { get; set;}
    
        /// <summary>
        /// Null or color
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set;}
    
        /// <summary>
        /// number between 0 and 1
        /// </summary>
        [JsonProperty(PropertyName = "backgroundOpacity")]
        public double? BackgroundOpacity { get; set;}
    
        /// <summary>
        /// null or jQuery object/DOM element/jQuery expression
        /// </summary>
        [JsonProperty(PropertyName = "container")]
        public string Container { get; set;}
    
        /// <summary>
        ///  null/false, true, "ascending", "descending", "reverse", or a comparatore
        /// </summary>
        [JsonProperty(PropertyName = "sorted")]
        public string Sorted { get; set; }
        
        /// <summary>
        /// Allows extra options to be added for plugins
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> ExtensionOptions = new Dictionary<string, object>();
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

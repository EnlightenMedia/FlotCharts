using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Series
    {
        /// <summary>
        /// Color or number
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "data")]
        List<List<object>> data;
        /// <summary>
        /// Rawdata
        /// </summary>
        public List<List<object>> Data
        {

            get
            {
                if (data == null)
                    data = new List<List<object>>();
                return data;
            }
            set
            {
                data = value;
            }
        }

        /// <summary>
        /// string
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        
        [JsonProperty(PropertyName = "lines")]
        Lines lines;
        /// <summary>
        /// Specific lines options
        /// </summary>
        public Lines Lines
        {
            get
            {
                if (lines == null)
                    lines = new Lines();
                return lines;
            }
            set
            {
                lines = value;
            }
        }
        
        [JsonProperty(PropertyName = "bars")]
        Bars bars;
        /// <summary>
        /// Specific bars options
        /// </summary>
        public Bars Bars
        {
            get
            {
                if (bars == null)
                    bars = new Bars();
                return bars;
            }
            set
            {
                bars = value;
            }
        }
        
        [JsonProperty(PropertyName = "points")]
        Points points;
        /// <summary>
        /// Specific bars options
        /// </summary>
        public Points Points
        {
            get
            {
                if (points == null)
                    points = new Points();
                return points;
            }
            set
            {
                points = value;
            }
        }

        /// <summary>
        /// Null or Number
        /// </summary>
        [JsonProperty(PropertyName = "xaxis")]
        public int? XAxis { get; set; }

        /// <summary>
        /// Null or Number
        /// </summary>
        [JsonProperty(PropertyName = "yaxis")]
        public int? YAxis { get; set; }
        
        /// <summary>
        /// Null, True or False
        /// </summary>
        [JsonProperty(PropertyName = "clickable")]
        public bool? Clickable { get; set; }

        /// <summary>
        /// Null, True or False
        /// </summary>
        [JsonProperty(PropertyName = "hoverable")]
        public bool? Hoverable { get; set; }
        

        /// <summary>
        /// Null or Number
        /// </summary>
        [JsonProperty(PropertyName = "shadowSize")]
        public int? ShadowSize { get; set; }
        
        /// <summary>
        /// Color or number
        /// </summary>
        [JsonProperty(PropertyName = "highlightColor")]
        public string HighlightColor { get; set; }

        /// <summary>
        /// Allows extra options to be added for plugins
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> ExtensionOptions = new Dictionary<string, object>();
    }
}

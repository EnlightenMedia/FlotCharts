using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class OptionsSeries : ICloneable
    {

        [JsonProperty]
        Bars bars;
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

        [JsonProperty]
        Lines lines;
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

        [JsonProperty]
        Points points;
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

        [JsonProperty(PropertyName = "pie")]
        Pie pie;
        public Pie Pie
        {
            get
            {
                if (Pie == null)
                    Pie = new Pie();
                return Pie;
            }
            set
            {
                Pie = value;
            }
        }

        [JsonProperty(PropertyName = "stack")]
        public bool? Stack { get; set; }
        [JsonProperty(PropertyName = "stackpercent")]
        public bool? Stackpercent { get; set; }
        [JsonProperty(PropertyName = "shadowSize")]
        public int? ShadowSize { get; set; }


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

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Axis : ICloneable
    {
        #region Flot Chart Axis Options
        /// <summary>
        /// Null or True/False
        /// </summary>
        [JsonProperty(PropertyName = "show")]
        public bool? Show { get; set; }

        /// <summary>
        /// "bottom" or "top" or "left" or "right"
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

        /// <summary>
        /// null or "time" ("time" requires jquery.flot.time.js plugin)
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// null, "browser" or timezone (only makes sense for mode: "time")
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// null or color spec
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// null or color spec
        /// </summary>
        [JsonProperty(PropertyName = "tickColor")]
        public string TickColor { get; set; }

        [JsonProperty(PropertyName = "font")]
        Font font;
        /// <summary>
        /// null or font object
        /// </summary>
        public Font Font
        {
            get
            {
                if (font == null)
                    font = new Font();
                return font;
            }
            set
            {
                font = value;
            }
        }

        /// <summary>
        /// null or number
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public double? Min { get; set; }

        /// <summary>
        /// null or number
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public double? Max { get; set; }

        /// <summary>
        /// null or number
        /// </summary>
        [JsonProperty(PropertyName = "autoscaleMargin")]
        public double? AutoscaleMargin { get; set; }

        /// <summary>
        /// null or fn: number -> number
        /// </summary>
        [JsonProperty(PropertyName = "transform")]
        public string Transform { get; set; }

        /// <summary>
        /// null or fn: number -> number
        /// </summary>
        [JsonProperty(PropertyName = "inverseTransform")]
        public string InverseTransform { get; set; }

        /// <summary>
        /// null or number or ticks array or (fn: axis -> ticks array)
        /// </summary>
        [JsonProperty(PropertyName = "ticks")]
        object Ticks { get; set; }

        /// <summary>
        /// number or array
        /// </summary>
        [JsonProperty(PropertyName = "tickSize")]
        public double? TickSize { get; set; }

        /// <summary>
        /// number or array
        /// </summary>
        [JsonProperty(PropertyName = "minTickSize")]
        public double? MinTickSize { get; set; }

        /// <summary>
        /// (fn: number, object -> string) or string
        /// </summary>
        [JsonProperty(PropertyName = "tickFormatter")]
        public string TickFormatter { get; set; }

        /// <summary>
        /// Number or array
        /// </summary>
        [JsonProperty(PropertyName = "tickDecimals")]
        public double? TickDecimals { get; set; }

        /// <summary>
        /// Null or number
        /// </summary>
        [JsonProperty(PropertyName = "labelWidth")]
        public double? LabelWidth { get; set; }

        /// <summary>
        /// Null or number
        /// </summary>
        [JsonProperty(PropertyName = "labelHeight")]
        public double? LabelHeight { get; set; }

        /// <summary>
        /// Null or True
        /// </summary>
        [JsonProperty(PropertyName = "reserveSpace")]
        public bool? ReserveSpace { get; set; }

        /// <summary>
        /// Null or number
        /// </summary>
        [JsonProperty(PropertyName = "tickLength")]
        public double? TickLength { get; set; }

        /// <summary>
        /// Null or number
        /// </summary>
        [JsonProperty(PropertyName = "alignTicksWithAxis")]
        public double? AlignTicksWithAxis { get; set; }

        /// <summary>
        /// Null or format string
        /// </summary>
        [JsonProperty(PropertyName = "timeformat")]
        public string Timeformat { get; set; }


        [JsonProperty(PropertyName = "monthNames")]
        List<string> monthNames;
        /// <summary>
        /// Null or array of size 12 of strings
        /// </summary>
        public List<string> MonthNames
        {
            get
            {
                if (monthNames == null)
                    monthNames = new List<string>();
                return monthNames;
            }
            set
            {
                monthNames = value;
            }
        }

        [JsonProperty(PropertyName = "dayNames")]
        List<string> dayNames;
        /// <summary>
        /// Null or array of size 7 of strings
        /// </summary>
        public List<string> DayNames
        {
            get
            {
                if (dayNames == null)
                    dayNames = new List<string>();
                return dayNames;
            }
            set
            {
                dayNames = value;
            }
        }

        /// <summary>
        /// Null or True
        /// </summary>
        [JsonProperty(PropertyName = "twelveHourClock")]
        public bool? TwelveHourClock { get; set; }


        #endregion

        /// <summary>
        /// Allows extra options to be added for plugins
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> ExtensionOptions = new Dictionary<string, object>();


        public Axis SetTicks(int count)
        {
            this.Ticks = count;
            return this;
        }

        public Axis SetTicks(List<List<object>> ticks)
        {
            this.Ticks = ticks;
            return this;
        }

        public Axis SetTicks(params List<object>[] ticks)
        {
            var newTicks = new List<List<object>>();
            newTicks.AddRange(ticks);
            this.Ticks = newTicks;
            return this;
        }

        public Axis ClearTicks()
        {
            this.Ticks = null;
            return this;
        }



        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

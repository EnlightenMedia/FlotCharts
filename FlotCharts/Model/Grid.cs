using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    public class Grid
    {
        /// <summary>
        /// Null or Boolean
        /// </summary>
        [JsonProperty(PropertyName = "show")]
        public bool? Show { get; set; }

        /// <summary>
        /// Null or Boolean
        /// </summary>
        [JsonProperty(PropertyName = "hoverable")]
        public bool? Hoverable { get; set; }

        /// <summary>
        /// Null or Boolean
        /// </summary>
        [JsonProperty(PropertyName = "clickable")]
        public bool? Clickable { get; set; }

        /// <summary>
        /// Null or Boolean
        /// </summary>
        [JsonProperty(PropertyName = "borderWidth")]
        object BorderWidth { get; set; }

        /// <summary>
        /// Null or Boolean
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        object BackgroundColor { get; set; }

        /// <summary>
        /// Null or Boolean
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// Null or Boolean
        /// </summary>
        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; }

        [JsonProperty(PropertyName = "markings")]
        List<Markings> markings;
        public List<Markings> Markings
        {
            get
            {
                if (markings == null)
                    markings = new List<Markings>();
                return markings;
            }
            set
            {
                markings = value;
            }
        }

        /// <summary>
        /// Allows extra options to be added for plugins
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> ExtensionOptions = new Dictionary<string, object>();


        public Grid SetBorderWidth(int top, int right, int bottom, int left)
        {
            this.BorderWidth = new
            {
                top = top,
                right = right,
                bottom = bottom,
                left = left
            }; ;
            return this;
        }

        public Grid SetBorderWidth(int width)
        {
            this.BorderWidth = width;
            return this;
        }


        public Grid ClearBorderWidth(int width)
        {
            this.BorderWidth = null;
            return this;
        }

        public Grid SetBackgroundColor(string color)
        {
            this.BackgroundColor = color;
            return this;
        }

        public Grid SetBackgroundColor(List<string> colors)
        {
            this.BackgroundColor = new { colors = colors };
            return this;
        }

        public Grid SetBackgroundColor(params string[] colors)
        {
            var newColors = new List<string>();
            newColors.AddRange(colors);
            this.BackgroundColor = new { colors = newColors };
            return this;
        }

        public Grid ClearBackgroundColor(string color)
        {
            this.BackgroundColor = null;
            return this;
        }

        
    //aboveData: boolean
    //color: color
    //margin: number or margin object
    //labelMargin: number
    //axisMargin: number
    //borderWidth: number or object with "top", "right", "bottom" and "left" properties with different widths
    //borderColor: color or null or object with "top", "right", "bottom" and "left" properties with different colors
    //minBorderMargin: number or null
    //autoHighlight: boolean
    //mouseActiveRadius: number
        
    }
}

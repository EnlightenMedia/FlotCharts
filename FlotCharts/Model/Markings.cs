using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Markings
    {
        [JsonProperty(PropertyName = "xaxis")]
        MarkingsAxis xaxis;
        public MarkingsAxis XAxis
        {
            get
            {
                if (xaxis == null)
                    xaxis = new MarkingsAxis();
                return xaxis;
            }
            set
            {
                xaxis = value;
            }
        }

        [JsonProperty(PropertyName = "yaxis")]
        MarkingsAxis yaxis;
        public MarkingsAxis YAxis
        {
            get
            {
                if (yaxis == null)
                    yaxis = new MarkingsAxis();
                return yaxis;
            }
            set
            {
                yaxis = value;
            }
        }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "lineWidth")]
        public double? LineWidth { get; set; }
    }
}

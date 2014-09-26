using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Options
    {
        [JsonProperty]
        OptionsSeries series;
        public OptionsSeries Series
        {
            get
            {
                if (series == null)
                    series = new OptionsSeries();
                return series;
            }
            set
            {
                series = value;
            }
        }

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

        [JsonProperty]
        Legend legend;
        public Legend Legend
        {
            get
            {
                if (legend == null)
                    legend = new Legend();
                return legend;
            }
            set
            {
                legend = value;
            }
        }

        [JsonProperty]
        Axis xaxis;
        public Axis XAxis
        {
            get
            {
                if (xaxis == null)
                    xaxis = new Axis();
                return xaxis;
            }
            set
            {
                xaxis = value;
            }
        }

        [JsonProperty]
        List<Axis> xaxes;
        public List<Axis> XAxes
        {
            get
            {
                if (xaxes == null)
                    xaxes = new List<Axis>();
                return xaxes;
            }
            set
            {
                xaxes = value;
            }
        }

        [JsonProperty]
        Axis yaxis;
        public Axis YAxis
        {
            get
            {
                if (yaxis == null)
                    yaxis = new Axis();
                return yaxis;
            }
            set
            {
                yaxis = value;
            }
        }

        [JsonProperty]
        List<Axis> yaxes;
        public List<Axis> YAxes
        {
            get
            {
                if (yaxes == null)
                    yaxes = new List<Axis>();
                return yaxes;
            }
            set
            {
                yaxes = value;
            }
        }

        [JsonProperty]
        Grid grid;
        public Grid Grid
        {
            get
            {
                if (grid == null)
                    grid = new Grid();
                return grid;
            }
            set
            {
                grid = value;
            }
        }

        /// <summary>
        /// Allows extra options to be added for plugins
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> ExtensionOptions = new Dictionary<string, object>();
        

        public Options()
        {

        }

    }
}

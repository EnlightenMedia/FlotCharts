using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    public class SeriesBar
    {
        public bool show { get; set; }
        public double barWidth { get; set; }
        public bool fill { get; set; }
        public int lineWidth { get; set; }
        public int order { get; set; }
        public string fillColor { get; set; }
    }
}

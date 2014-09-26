using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    public class PieLabel
    {


        /// <summary>
        /// Allows extra options to be added for plugins
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> ExtensionOptions = new Dictionary<string, object>();
        
        public bool show { get; set; }
        public double radius  { get; set; }
        public object formatter { get; set; }
        public PieLabelBackground background {get; set; }
    }
}

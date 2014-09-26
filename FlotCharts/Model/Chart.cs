using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EM.FlotCharts.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Chart
    {
        [JsonProperty]
        Options options = null;
        public Options Options
        {
            get
            {
                if (options == null)
                    options = new Options();
                return options;
            }
            set
            {
                options = value;
            }
        }

        [JsonProperty]
        List<Series> data;
        public List<Series> Data
        {
            get
            {
                if (data == null)
                    data = new List<Series>();
                return data;
            }
            set
            {
                data = value;
            }
        }

        public void AddDataSeries(Series series)
        {
            Data.Add(series);
        }

        public Series AddDataSeries(List<List<object>> data, string label, string color)
        {
            var series = AddDataSeries(data);
            series.Label = label;
            series.Color = color;
            return series;
        }

        public Series AddDataSeries(List<List<object>> data, string label)
        {
            var series = AddDataSeries(data);
            series.Label = label;
            return series;
        }

        public Series AddDataSeries(List<List<object>> data)
        {
            var series = new Series();
            series.Data = data;
            Data.Add(series);
            return series;
        }

        public Chart()
        {
        }
    }
}

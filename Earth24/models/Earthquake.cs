using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Earth24.models
{

    public class Earthquake
{
        public string type { get; set; }
        public Feature[] features { get; set; }
        public float[] bbox { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public Geometry geometry { get; set; }
        public string id { get; set; }
    }

    public class Properties
    {
        
        public float? mag { get; set; }
        public string place { get; set; }
        public long time { get; set; }
        public long updated { get; set; }
        public int? felt { get; set; }
        public string alert { get; set; }
        public string status { get; set; }
        public int tsunami { get; set; }
        public int sig { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public float[] coordinates { get; set; }

    }

    public class Earthquake1
    {

        public Feature1[] features { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class Feature1
    {
    
        public Geometry1 geometry { get; set; }
        public Properties1 properties { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class Properties1
    {

        public float? mag { get; set; }
        public string place { get; set; }
        public long time { get; set; }
        public int? felt { get; set; }
        public string alert { get; set; }
        public string status { get; set; }
        public int tsunami { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Geometry1
    {
        public float[] coordinates { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }



}

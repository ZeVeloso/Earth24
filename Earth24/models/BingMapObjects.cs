using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Earth24.models
{
    public class Location
    {
        public float latitude;
        public float longitude;

        public Location(float lat, float lon)
        {
            latitude = lat;
            longitude = lon;
        }
        public Location()
        {
            latitude = 0;
            longitude = 0;
        }
    }

    public class Pushpin
    {
        public string color;
        public Location location;
    }

    public class PolygonOptions
    {
        public string fillColor;
        public string strokeColor;
        public int strokeThickness;
    }

    public class Polygon
    {
        public Location[][] rings;
        public PolygonOptions options;
    }
}

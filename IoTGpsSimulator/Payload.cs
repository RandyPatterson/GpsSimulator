using System;
using System.Collections.Generic;
using System.Text;

namespace IoTGpsSimulator
{
    public class Payload
    {
        public Payload(decimal latitude, decimal longitude)
        {
            Location = new geoJson(latitude, longitude);
        }

        public string DeviceId { get; set; }
        public geoJson Location { get; set; }

        public class geoJson
        {
            public geoJson(decimal latitude, decimal longitude)
            {
                this.type = "Point";
                //GeoJSON is Longitude,Latitude
                this.coordinates = new[] { longitude, latitude };
            }

            public string type { get; set; }
            public decimal[] coordinates { get; set; }
        }

    }
}

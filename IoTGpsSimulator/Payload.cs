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
                this.Type = "Point";
                //GeoJSON is Longitude,Latitude
                this.Coordinates = new[] { longitude, latitude };
            }

            public string Type { get; set; }
            public decimal[] Coordinates { get; set; }
        }

    }
}

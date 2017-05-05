

namespace IoTGpsSimulator
{
    public class GeoPoint
    {
        public GeoPoint(decimal latitude, decimal longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
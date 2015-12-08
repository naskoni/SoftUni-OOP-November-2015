using System;

namespace _01.GalacticGPS
{
    public struct Location
    {
        private const int MinLatitude = -90;
        private const int MaxLatitude = 90;
        private const int MinLongitude = -180;
        private const int MaxLongitude = 180;
        private const string ExceptionMessage = "The {0} should be in range {1}..{2}";

        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planetName)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.PlanetName = planetName;
        }

        public double Latitude
        {
            get { return this.latitude; }

            private set
            {
                if (value < MinLatitude || value > MaxLatitude)
                {
                    throw new ArgumentOutOfRangeException(string.Format(
                        ExceptionMessage, nameof(latitude), MinLatitude, MaxLatitude));
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }

            private set
            {
                if (value < MinLongitude || value > MaxLongitude)
                {
                    throw new ArgumentOutOfRangeException(string.Format(
                        ExceptionMessage, nameof(latitude), MinLongitude, MaxLongitude));
                }
                this.longitude = value;
            }
        }

        public Planet PlanetName { get; set; }

        public override string ToString()
        {
            return $"{this.Latitude}, {this.Longitude} - {this.PlanetName}";
        }
    }
}

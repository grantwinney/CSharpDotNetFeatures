namespace PrimaryConstructors.Entities;

internal struct SatellitePosition1
{
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public decimal Altitude { get; init; }
    public DateTimeOffset Time { get; set; }

    public SatellitePosition1(string latitude, string longitude, decimal altitude, DateTimeOffset time)
    {
        Latitude = latitude;
        Longitude = longitude;
        Altitude = altitude;
        Time = time;
    }
}

internal struct SatellitePosition2(string latitude, string longitude, decimal altitude, DateTimeOffset time)
{
    public string Latitude { get; set; } = latitude;
    public string Longitude { get; set; } = longitude;
    public decimal Altitude { get; init; } = altitude;
    public DateTimeOffset Time { get; set; } = time;

    public SatellitePosition2() : this("", "", 0, DateTimeOffset.MinValue)
    {
        // other important stuff to do on instantiation
    }
}

internal record struct SatellitePosition3(string Latitude, string Longitude, decimal Altitude, DateTimeOffset Time)
{
    public decimal Altitude { get; init; } = Altitude;
}

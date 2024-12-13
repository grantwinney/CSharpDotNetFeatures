using PrimaryConstructors.Entities;

var s1 = new Satellite1("Navstar 82", "US", new DateOnly(2023,1,17), false);

s1.Owner = "Bob";
s1.IsActive = true;

var s2 = new Satellite2("Navstar 82", "US", new DateOnly(2023, 1, 17), false);

s2.Owner = "Bob";
s2.IsActive = true;

var s3 = new Satellite3("Navstar 82", "US", new DateOnly(2023, 1, 17), false);

s3.Owner = "Bob";
s3.IsActive = true;


var sp1 = new SatellitePosition1("44.3°N", "25.3°W", 20186, DateTimeOffset.UtcNow);

sp1.Latitude = "44.3°S";
sp1.Altitude = 21000;

var sp2 = new SatellitePosition2();

sp2.Latitude = "44.3°S";
sp2.Altitude = 21000;

var sp3 = new SatellitePosition3("44.3°N", "25.3°W", 20186, DateTimeOffset.UtcNow);

sp3.Latitude = "44.3°S";
sp3.Altitude = 21000;


Console.WriteLine($"{s3.Name} ({s3.Owner}) location info: {sp3}");

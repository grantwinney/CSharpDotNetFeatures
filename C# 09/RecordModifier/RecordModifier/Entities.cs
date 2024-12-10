namespace RecordModifier;

public class Plane(string Make, string Model, int Year)
{
    public string Make { get; set; } = Make;
    public string Model { get; set; } = Model;
    public int Year { get; set; } = Year;
}

public class Train(string Make, string Model, int Year) : IEquatable<Train>
{
    public string Make { get; set; } = Make;
    public string Model { get; set; } = Model;
    public int Year { get; set; } = Year;

    public static bool operator ==(Train? x, Train? y)
    {
        if (x is null || y is null)
            return false;

        return x.Make == y.Make && x.Model == y.Model && x.Year == y.Year;
    }

    public static bool operator !=(Train? x, Train? y)
    {
        return !(x == y);
    }

    // IEquatable<T>
    public bool Equals(Train? other)
    {
        return this == other;
    }
}


public record Automobile(string Make, string Model, int Year);
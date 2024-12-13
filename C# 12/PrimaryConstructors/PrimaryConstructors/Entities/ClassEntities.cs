namespace PrimaryConstructors.Entities;

internal class Satellite1
{
    public string Name { get; init; }
    public string Owner { get; init; }
    public DateOnly LaunchDate { get; init; }
    public bool IsActive { get; set; }

    public Satellite1(string name, string owner, DateOnly launchDate, bool isActive)
    {
        Name = name;
        Owner = owner;
        LaunchDate = launchDate;
        IsActive = isActive;
    }
}

internal class Satellite2(string name, string owner, DateOnly launchDate, bool isActive)
{
    public string Name { get; init; } = name;
    public string Owner { get; init; } = owner;
    public DateOnly LaunchDate { get; init; } = launchDate;
    public bool IsActive { get; set; } = isActive;
}

internal record class Satellite3(string Name, string Owner, DateOnly LaunchDate, bool IsActive)
{
    public bool IsActive { get; set; } = IsActive;
}

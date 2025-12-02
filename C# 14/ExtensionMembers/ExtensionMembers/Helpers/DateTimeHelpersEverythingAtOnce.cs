using System.Reflection;

namespace Helpers.DateTimeExtensionMembersAndMore;

// C# 14 extension members
public static class DateTimeHelpers
{
    public static readonly DateTime Yesterday;

    // Static Constructor, because why not..
    static DateTimeHelpers()
    {
        Yesterday = DateTime.Yesterday;
    }

    // Simple Method
    public static string GetStats()
    {
        var i = typeof(DateTimeHelpers).GetMethods(BindingFlags.Static | BindingFlags.Public).Length;
        return $"{nameof(DateTimeHelpers)} has {i} properties.";
    }

    // Extension Method
    public static int GetPreviousLeapYear(this DateTime dt) =>
        Enumerable.Range(dt.Year - 4, 4).Single(DateTime.IsLeapYear);

    // Extension Members
    extension(DateTime dt)
    {
        // Static Method
        public static string GetDailyHoroscope()
            => "Carpe die.. seize the dice! 🎲🎲";

        // Static Properties
        public static DateTime Yesterday => DateTime.UtcNow.AddDays(-1);
        public static DateTime Tomorrow => DateTime.UtcNow.AddDays(1);

        // Instance Method
        public int GetNextLeapYear() =>
            Enumerable.Range(dt.Year + 1, 4).Single(DateTime.IsLeapYear);

        // Instance Properties
        public DateTime NextWeek => dt.AddDays(7);
        public bool IsFutureDate => dt > DateTime.UtcNow;

        // Operator
        public static DateTime operator +(DateTime dt1, int days)
            => dt1.AddDays(days);
    }
}

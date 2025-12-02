namespace Helpers.DateTimeExtensionMembers;

// C# 14 extension members
public static class DateTimeHelpers
{
    extension(DateTime)
    {
        public static DateTime Yesterday => DateTime.UtcNow.AddDays(-1);
        public static DateTime Tomorrow => DateTime.UtcNow.AddDays(1);

        public static string Weekday => DateTime.UtcNow.DayOfWeek.ToString();

        public static bool IsTodayTomorrow => false;

        public static string GetDailyHoroscope()
            => "Carp diem.. seize the fish! Or is it fish the day? 🐟";

        public static DateTime operator +(DateTime dt, int days)
            => dt.AddDays(days);
    }
}

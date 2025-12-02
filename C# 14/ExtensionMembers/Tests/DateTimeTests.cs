using Helpers.DateTimeExtensionMembers;

namespace Tests;

public class DateTimeTests
{
    [Test]
    public void IsYesterdayReallyYesterday()
    {
        var yesterday = DateTime.UtcNow.AddDays(-1).Date;
        Assert.That(DateTime.Yesterday.Date, Is.EqualTo(yesterday));
    }

    [Test]
    public void IsTomorrowReallyTomorrow()
    {
        var tomorrow = DateTime.UtcNow.AddDays(1).Date;
        Assert.That(DateTime.Tomorrow.Date, Is.EqualTo(tomorrow));
    }

    [Test]
    public void IsDayOfWeekCorrect()
    {
        var dayOfWeek = DateTime.UtcNow.DayOfWeek.ToString();
        Assert.That(DateTime.Weekday, Is.EqualTo(dayOfWeek));
    }

    [Test]
    public void IsTodayTomorrow()
    {
        Assert.That(DateTime.IsTodayTomorrow, Is.False);
    }
}

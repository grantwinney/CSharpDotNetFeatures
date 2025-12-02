using Helpers.DateTimeExtensionMembers;
using Helpers.ExtensionMembers;
using System.Text;

namespace ExtensionMembers;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        var example = "hello world from extension methods";
        var titleCased = example.ToTitleCase();
        Console.WriteLine(titleCased);

        Console.WriteLine(DateTime.Yesterday);
        Console.WriteLine(DateTime.Tomorrow);
        Console.WriteLine(DateTime.GetDailyHoroscope());
    }
}
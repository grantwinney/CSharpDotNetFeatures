using System.Text.RegularExpressions;

namespace Helpers.ExtensionMethods;

public static class BlogStringHelpers
{
    // Truncate post for summary, as for use in social media.
    public static string ToExcerpt(this string str, int maxLength = 128) =>
        str.Length <= maxLength ? str : $"{str[..maxLength]}...";

    // Convert string to a slug to use as identifier for post.
    public static string ToSlug(this string str) =>
        Regex.Replace(str.Trim().ToLower(), @"\s+", "-");

    // Convert string to Title Case to use as title for post.
    public static string ToTitleCase(this string str)
    {
        var words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            var w = words[i];
            words[i] = char.ToUpper(w[0]) + w.Substring(1, w.Length - 1);
        }
        return string.Join(' ', words);
    }
}

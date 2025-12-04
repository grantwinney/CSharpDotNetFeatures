using System.Text.RegularExpressions;

namespace Helpers.ExtensionMembers;

// C# 14 extension members
public static class BlogStringHelpers
{
    extension(string str)
    {
        // Truncate post for summary, as for use in social media.
        public string ToExcerpt(int maxLength = 128) =>
            str.Length <= maxLength ? str : $"{str[..maxLength]}...";

        // Convert string to a slug to use as identifier for post.
        public string ToSlug() =>
            Regex.Replace(str.Trim().ToLower(), @"\s+", "-");

        // Convert string to Title Case to use as title for post.
        public string ToTitleCase()
        {
            var words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                var w = words[i];
                words[i] = char.ToUpper(w[0]) + w.Substring(1, w.Length - 1);
            }
            return string.Join(' ', words);
        }

        public bool IsTitleTooLong => str.Length > 100;

        public bool IsTitleAlphanumeric =>
            str.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c));
    }
}

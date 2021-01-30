using System.Linq;

namespace Goblinfactory.Delimited
{
    internal static class DelimHelper
    {
        public static string[] SplitAndTrimUpper(this string text, char delim)
        {
            if (string.IsNullOrWhiteSpace(text)) return new string[0];
            var splits = text.Split(delim);
            return splits.Select(s => s.Trim().ToUpperInvariant()).ToArray();
        }

        public static string[] SplitAndTrimLower(this string text, char delim)
        {
            if (string.IsNullOrWhiteSpace(text)) return new string[0];
            var splits = text.Split(delim);
            return splits.Select(s => s.Trim().ToLowerInvariant()).ToArray();
        }
        public static string[] SplitAndTrim(this string text, char delim)
        {
            if (string.IsNullOrWhiteSpace(text)) return new string[0];
            var splits = text.Split(delim);
            return splits.Select(s => s.Trim()).ToArray();
        }
    }
}

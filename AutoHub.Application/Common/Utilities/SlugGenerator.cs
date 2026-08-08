
using System.Text;

namespace AutoHub.Application.Common.Utilities
{
    public static class SlugGenerator
    {
        private static readonly Dictionary<char, string> BgToEnMap = new()
        {
            ['а'] = "a",
            ['б'] = "b",
            ['в'] = "v",
            ['г'] = "g",
            ['д'] = "d",
            ['е'] = "e",
            ['ж'] = "zh",
            ['з'] = "z",
            ['и'] = "i",
            ['й'] = "y",
            ['к'] = "k",
            ['л'] = "l",
            ['м'] = "m",
            ['н'] = "n",
            ['о'] = "o",
            ['п'] = "p",
            ['р'] = "r",
            ['с'] = "s",
            ['т'] = "t",
            ['у'] = "u",
            ['ф'] = "f",
            ['х'] = "h",
            ['ц'] = "ts",
            ['ч'] = "ch",
            ['ш'] = "sh",
            ['щ'] = "sht",
            ['ъ'] = "a",
            ['ь'] = "",
            ['ю'] = "yu",
            ['я'] = "ya"
        };

        public static string GenerateSlug(string input)
        {
            var lower = input.Trim().ToLowerInvariant();

            var transliterated = new StringBuilder();
            foreach (var ch in lower)
            {
                transliterated.Append(BgToEnMap.TryGetValue(ch, out var replacement) ? replacement : ch.ToString());
            }

            var result = new StringBuilder();
            foreach (var ch in transliterated.ToString())
            {
                if (char.IsLetterOrDigit(ch))
                {
                    result.Append(ch);
                }
                else if (char.IsWhiteSpace(ch) || ch == '-')
                {
                    if (result.Length > 0 && result[^1] != '-')
                    {
                        result.Append('-');
                    }
                }
            }

            return result.ToString().Trim('-');
        }
    }
}
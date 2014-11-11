using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveSplit.Model
{
    public static partial class StringExtensions
    {
        public static IEnumerable<string> Wrap(this string str, int maxLength)
        {
            var charCount = 0;
            var lines = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return lines.GroupBy(w => (charCount += w.Length + 1) / (maxLength + 2)).Select(g => string.Join(" ", g.ToArray())).ToArray();
        }
    }
}

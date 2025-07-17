using System;
using System.Collections.Generic;
using System.Linq;

public class FindPairsSolver
{
    public static List<string> FindPairs(List<string> words)
    {
        var seen = new HashSet<string>();
        var result = new List<string>();

        foreach (var word in words)
        {
            if (word[0] == word[1]) continue; // Skip same-letter words like "aa"
            var reverse = new string(word.Reverse().ToArray());
            if (seen.Contains(reverse))
            {
                result.Add($"{reverse} & {word}");
            }
            seen.Add(word);
        }

        return result;
    }
}

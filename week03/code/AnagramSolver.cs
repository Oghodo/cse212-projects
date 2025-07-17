using System;
using System.Collections.Generic;
using System.Linq;

public class AnagramSolver
{
    public static bool IsAnagram(string word1, string word2)
    {
        string Clean(string s) => new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray());

        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();

        foreach (var c in Clean(word1))
        {
            if (!dict1.ContainsKey(c)) dict1[c] = 0;
            dict1[c]++;
        }

        foreach (var c in Clean(word2))
        {
            if (!dict2.ContainsKey(c)) dict2[c] = 0;
            dict2[c]++;
        }

        return dict1.Count == dict2.Count && !dict1.Except(dict2).Any();
    }
}

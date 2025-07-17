using System;
using System.Collections.Generic;
using System.IO;

public class DegreeSummarySolver
{
    public static Dictionary<string, int> SummarizeDegrees(string filePath)
    {
        var degrees = new Dictionary<string, int>();
        foreach (var line in File.ReadLines(filePath))
        {
            var parts = line.Split(',');
            if (parts.Length >= 4)
            {
                var degree = parts[3].Trim();
                if (!string.IsNullOrEmpty(degree))
                {
                    if (!degrees.ContainsKey(degree))
                        degrees[degree] = 0;
                    degrees[degree]++;
                }
            }
        }
        return degrees;
    }
}

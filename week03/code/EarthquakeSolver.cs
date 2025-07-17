using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class EarthquakeSolver
{
    public class FeatureCollection
    {
        [JsonPropertyName("features")]
        public List<Feature> Features { get; set; }
    }

    public class Feature
    {
        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    }

    public class Properties
    {
        [JsonPropertyName("place")]
        public string Place { get; set; }

        [JsonPropertyName("mag")]
        public double? Mag { get; set; }
    }

    public static string[] EarthquakeDailySummary(string json)
    {
        var result = new List<string>();
        var data = JsonSerializer.Deserialize<FeatureCollection>(json);

        if (data?.Features != null)
        {
            foreach (var feature in data.Features)
            {
                var place = feature?.Properties?.Place;
                var mag = feature?.Properties?.Mag;

                if (!string.IsNullOrEmpty(place) && mag.HasValue)
                {
                    result.Add($"{place} - Mag {mag.Value}");
                }
            }
        }

        return result.ToArray();
    }
}

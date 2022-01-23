using System.Text.Json.Serialization;

public class CensusData 
{
    public int? Id { get; set; }

    [JsonPropertyName("District")]
    public string District { get; set; }

    [JsonPropertyName("Zone")]
    public string Zone { get; set; }

    [JsonPropertyName("Ecological_Belt")]
    public string EcologicalBelt { get; set; }

    [JsonPropertyName("Development_Region")]
    public string DevelopmentRegion { get; set; }

    [JsonPropertyName("Caste")]
    public string Caste { get; set; }
    
    [JsonPropertyName("Indicator")]
    public string Gender { get; set; }

    [JsonPropertyName("Value")]
    public int Value { get; set; }

}
using System;
using Newtonsoft.Json;
// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class BridgeMonitor_Model
{
    [JsonProperty("boat_name")]
    public string BoatName { get; set; }

    [JsonProperty("closing_type")]
    public string ClosingType { get; set; }

    [JsonProperty("closing_date")]
    public DateTime ClosingDate { get; set; }

    [JsonProperty("reopening_date")]
    public DateTime ReopeningDate { get; set; }
}


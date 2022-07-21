using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// Status Health
    /// </summary>
    public class Health
    {
        [JsonPropertyName("happy")]
        public bool Happy { get; set; }
        [JsonPropertyName("api_ready")]
        public bool ApiReady { get; set; }
        [JsonPropertyName("tip_age")]
        public long TipAge { get; set; }
        [JsonPropertyName("node_connections")]
        public long NodeConnections { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// API Status
    /// </summary>
    public class APIStatus
    {
        [JsonPropertyName("ready")]
        public bool Ready { get; set; }
        [JsonPropertyName("db_height")]
        public long DBHeight { get; set; }
        [JsonPropertyName("db_block_time")]
        public long DBBlockTime { get; set; }
        [JsonPropertyName("node_height")]
        public long NodeHeight { get; set; }
        [JsonPropertyName("node_connections")]
        public long NodeConnections { get; set; }
        [JsonPropertyName("api_version")]
        public long APIVersion { get; set; }
        [JsonPropertyName("dcrdata_version")]
        public string? DcrdataVersion { get; set; }
        [JsonPropertyName("network_name")]
        public string? NetworkName { get; set; }
    }
}

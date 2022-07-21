using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class TicketPoolInfo
    {
        [JsonPropertyName("height")]
        public long Height { get; set; }
        [JsonPropertyName("size")]
        public long Size { get; set; }
        [JsonPropertyName("value")]
        public float Value { get; set; }
        [JsonPropertyName("valavg")]
        public float ValAvg { get; set; }

        [JsonPropertyName("winners")]
        public ICollection<string> Winners { get; set; } = new List<string>();
    }
}
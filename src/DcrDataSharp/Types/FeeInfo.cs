using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class FeeInfo
    {
        [JsonPropertyName("height")]
        public long Height { get; set; }
        [JsonPropertyName("number")]
        public long Number { get; set; }
        [JsonPropertyName("min")]
        public long Min { get; set; }
        [JsonPropertyName("max")]
        public long Max { get; set; }
        [JsonPropertyName("mean")]
        public long Mean { get; set; }
        [JsonPropertyName("median")]
        public long Median { get; set; }
        [JsonPropertyName("stddev")]
        public long StdDev { get; set; }
    }
}
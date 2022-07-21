using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// Treasury Balance
    /// </summary>
    public class TreasuryBalance
    {
        [JsonPropertyName("height")]
        public long Height { get; set; }
        [JsonPropertyName("maturity_height")]
        public long MaturityHeight { get; set; }
        [JsonPropertyName("balance")]
        public long Balance { get; set; }
        [JsonPropertyName("output_count")]
        public long OutputCount { get; set; }
        [JsonPropertyName("add_count")]
        public long AddCount { get; set; }
        [JsonPropertyName("added")]
        public long Added { get; set; }
        [JsonPropertyName("spend_count")]
        public long SpendCount { get; set; }
        [JsonPropertyName("spend")]
        public long Spent { get; set; }
        [JsonPropertyName("tbase_count")]
        public long TBaseCount { get; set; }
        [JsonPropertyName("tbase")]
        public long TBase { get; set; }
        [JsonPropertyName("immature_count")]
        public long ImmatureCount { get; set; }
        [JsonPropertyName("immature")]
        public long Immature { get; set; }
    }
}
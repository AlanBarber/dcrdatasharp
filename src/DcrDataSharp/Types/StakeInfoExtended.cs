using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class StakeInfoExtended
    {
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }
        [JsonPropertyName("feeinfo")]
        public FeeInfo? FeeInfo { get; set; }
        [JsonPropertyName("stakediff")]
        public float StakeDiff { get; set; }
        [JsonPropertyName("window_number")]
        public long WindowNumber { get; set; }
        [JsonPropertyName("window_block_index")]
        public long WindowBlockIndex { get; set; }
        [JsonPropertyName("ticket_pool")]
        public TicketPoolInfo? TicketPool { get; set; }
    }
}

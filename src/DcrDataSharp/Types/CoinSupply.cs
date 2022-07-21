using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class CoinSupply
    {
        [JsonPropertyName("block_height")]
        public int BlockHeight { get; set; }
        [JsonPropertyName("block_hash")]
        public string BlockHash { get; set; }
        [JsonPropertyName("supply_mined")]
        public long SupplyMined { get; set; }
        [JsonPropertyName("supply_ultimate")]
        public long SupplyUltimate { get; set; }
    }

}

using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class BlockTransactionCounts
    {
        [JsonPropertyName("tx")]
        public int Transactions { get; set; }
        [JsonPropertyName("stx")]
        public int StakeTransactions { get; set; }
    }
}
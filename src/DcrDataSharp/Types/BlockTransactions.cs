using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class BlockTransactions
    {
        [JsonPropertyName("tx")]
        public ICollection<string> Transactions { get; set; } = new List<string>();
        [JsonPropertyName("stx")]
        public ICollection<string> StakeTransactions { get; set; } = new List<string>();
    }
}

using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class BlockVerboseResult
    {
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }
        [JsonPropertyName("confirmations")]
        public long Confirmations { get; set; }
        [JsonPropertyName("size")]
        public long Size { get; set; }
        [JsonPropertyName("height")]
        public long Height { get; set; }
        [JsonPropertyName("version")]
        public long Version { get; set; }
        [JsonPropertyName("merkleroot")]
        public string? MerkleRoot { get; set; }
        [JsonPropertyName("stakeroot")]
        public string? StakeRoot { get; set; }
        [JsonPropertyName("tx")]
        public ICollection<string> Transactions { get; set; } = new List<string>();
        [JsonPropertyName("stx")]
        public ICollection<string> StakeTransactions { get; set; } = new List<string>();
        [JsonPropertyName("time")]
        public long Time { get; set; }
        [JsonPropertyName("mediantime")]
        public long MedianTime { get; set; }
        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }
        [JsonPropertyName("votebits")]
        public long VoteBits { get; set; }
        [JsonPropertyName("finalstate")]
        public string? FinalState { get; set; }
        [JsonPropertyName("voters")]
        public long Voters { get; set; }
        [JsonPropertyName("freshstake")]
        public long FreshStake { get; set; }
        [JsonPropertyName("revocations")]
        public long Revocations { get; set; }
        [JsonPropertyName("poolsize")]
        public long PoolSize { get; set; }
        [JsonPropertyName("bits")]
        public string? Bits { get; set; }
        [JsonPropertyName("sbits")]
        public float SBits { get; set; }
        [JsonPropertyName("extradata")]
        public string? ExtraData { get; set; }
        [JsonPropertyName("stakeversion")]
        public long StakeVersion { get; set; }
        [JsonPropertyName("difficulty")]
        public float Difficulty { get; set; }
        [JsonPropertyName("chainwork")]
        public string? ChainWork { get; set; }
        [JsonPropertyName("previousblockhash")]
        public string? PreviousBlockHash { get; set; }
        [JsonPropertyName("nextblockhash")]
        public string? NextBlockHash { get; set; }
    }

}

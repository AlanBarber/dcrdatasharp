using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{

    public class BlockDataBasic
    {
        [JsonPropertyName("height")]
        public long Height { get; set; }
        [JsonPropertyName("Size")]
        public int Size { get; set; }
        [JsonPropertyName("Hash")]
        public string? Hash { get; set; }
        [JsonPropertyName("diff")]
        public float Diff { get; set; }
        [JsonPropertyName("sdiff")]
        public float SDiff { get; set; }
        [JsonPropertyName("time")]
        public long Time { get; set; }
        [JsonPropertyName("txlength")]
        public long TxLength { get; set; }
        [JsonPropertyName("ticket_pool")]
        public TicketPoolInfo? TicketPool { get; set; }
    }

    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public string name { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public int votingStarted { get; set; }
        public int votingdone { get; set; }
        public int activated { get; set; }
        public int hardforked { get; set; }
        public DateTime starttime { get; set; }
        public DateTime expiretime { get; set; }
        public int voteversion { get; set; }
        public int mask { get; set; }
    }

}

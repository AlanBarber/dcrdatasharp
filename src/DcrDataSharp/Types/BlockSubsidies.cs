using System.Text.Json.Serialization;

namespace DcrDataSharp.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class BlockSubsidies
    {
        [JsonPropertyName("height")]
        public long Height { get; set; }
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }
        [JsonPropertyName("work_reward")]
        public long WorkReward { get; set; }
        [JsonPropertyName("stake_reward")]
        public long StakeReward { get; set; }
        [JsonPropertyName("num_votes")]
        public long NumVotes { get; set; }
        [JsonPropertyName("stake_reward_total")]
        public long StakeRewardTotal { get; set; }
        [JsonPropertyName("project_subsidy")]
        public long ProjectSubsidy { get; set; }
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }

}

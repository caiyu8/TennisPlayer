using Newtonsoft.Json;

namespace TennisPlayer.API.Models
{
    public class Data
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("weights")]
        public int Weights { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("last")]
        public int[] Last { get; set; }
    }
}

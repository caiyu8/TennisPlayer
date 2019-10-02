using Newtonsoft.Json;

namespace TennisPlayer.API.Models
{
    public class Country
    {
        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}

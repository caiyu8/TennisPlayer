using Newtonsoft.Json;

namespace TennisPlayer.API.Models
{
    public class Player
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LasName { get; set; }

        [JsonProperty("shortname")]
        public string ShortName { get; set; }

        [JsonProperty("sex")]
        public Sex Sex { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}

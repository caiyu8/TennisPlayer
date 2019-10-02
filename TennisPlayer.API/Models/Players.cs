using Newtonsoft.Json;
using System.Collections.Generic;

namespace TennisPlayer.API.Models
{
    public class Players
    {
        [JsonProperty("players")]
        public List<Player> PlayerList { get; set; }
    }
}

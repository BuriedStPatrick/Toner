using Newtonsoft.Json;

namespace Toner.Core.Models
{
    public class Tone
    {
        [JsonProperty("score")]
        public float Score { get; set; }
        [JsonProperty("tone_id")]
        public string Id { get; set; }
        [JsonProperty("tone_name")]
        public string Name { get; set; }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Toner.Core.Models
{
    public class Category
    {
        [JsonProperty("tones")]
        public IEnumerable<Tone> Tones { get; set; }
        [JsonProperty("category_id")]
        public string Id { get; set; }
        [JsonProperty("category_name")]
        public string Name { get; set; }
    }
}

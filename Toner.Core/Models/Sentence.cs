using System.Collections.Generic;
using Newtonsoft.Json;

namespace Toner.Core.Models
{
    public class Sentence
    {
        [JsonProperty("sentence_id")]
        public int Id { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("input_from")]
        public int InputFrom { get; set; }
        [JsonProperty("input_to")]
        public int InputTo { get; set; }
        [JsonProperty("tone_categories")]
        public IEnumerable<Category> Categories { get; set; }
        [JsonProperty("className")]
        public string ClassName { get; set; }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Toner.Core.Models
{
    public class Result
    {
        [JsonProperty("sentences_tone")]
        public IEnumerable<Sentence> Sentences { get; set; }
    }
}
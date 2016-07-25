using Newtonsoft.Json;

namespace Toner.Core.Models
{
    public class Parameter
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        public Parameter(string text)
        {
            Text = text;
        }
    }
}

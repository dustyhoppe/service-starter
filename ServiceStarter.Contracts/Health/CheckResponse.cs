using System.Text.Json.Serialization;

namespace ServiceStarter.Contracts.Health
{
    public class CheckResponse
    {
        [JsonPropertyName("thumbsUp")]
        public bool ThumbsUp { get; set; }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Entities
{
    public class Response
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }

        public string Description { get; set; }
    }
    public enum Status
    {
        Success, Failure
    }
}
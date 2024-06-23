using Newtonsoft.Json;

namespace Company.function
{
    [JsonProperty(PropertyName="Id")]
    public class Counter{
        public string Id {get; set;}
        public int Count {get; set;}
    }
}
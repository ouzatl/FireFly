using Newtonsoft.Json;

namespace FireFly.Contract.Authentication
{
    public class AuthenticationResponseContract
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
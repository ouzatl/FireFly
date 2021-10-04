using Newtonsoft.Json;

namespace FireFly.Contract.Authentication
{
    public class AuthenticationContract
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
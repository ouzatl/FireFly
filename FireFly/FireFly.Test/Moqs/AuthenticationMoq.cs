using FireFly.Service.Authentication;

namespace FireFly.Test.Moqs
{
    public class AuthenticationMoq
    {
        public static IAuthenticationService GetAuthenticationService() => new AuthenticationService();

        public const string successLoginEmail = "eve.holt@reqres.in";
        public const string successLoginPassword = "pistol";
        public const string successRegisterEmail = "eve.holt@reqres.in";
        public const string successRegisterPassword = "pistol123";
        public const string failLoginEmail = "peter@klaven";
        public const string failLoginPassword = "pistol123";
        public const string failRegisterEmail = "sydney@fife";
        public const string failRegisterPassword = "pistol123";
    }
}
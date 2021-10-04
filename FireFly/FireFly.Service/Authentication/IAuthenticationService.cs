using FireFly.Contract.Authentication;
using System.Threading.Tasks;

namespace FireFly.Service.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> Login(AuthenticationContract contract);
        Task<bool> Register(AuthenticationContract contract);
    }
}
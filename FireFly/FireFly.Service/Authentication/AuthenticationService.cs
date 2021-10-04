using FireFly.Common.Constants;
using FireFly.Common.Helpers;
using FireFly.Contract.Authentication;
using FireFly.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FireFly.Service.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private UnitOfWork unitOfWork;
        private HttpHelper httpHelper;

        public AuthenticationService()
        {
            httpHelper = new HttpHelper();
            unitOfWork = new UnitOfWork(new FireFlyContext());
        }

        public async Task<bool> Login(AuthenticationContract contract)
        {
            var settings = await unitOfWork.SystemSettingsRepository.GetSystemSettings(ReqResConstant.reqres);
            var result = httpHelper.PostRequest<
                AuthenticationContract,
                AuthenticationResponseContract>
                (string.Concat(
                     settings.FirstOrDefault(x => x.Key == ReqResConstant.reqresUrl).Value,
                     settings.FirstOrDefault(x => x.Key == ReqResConstant.loginUri).Value),
                contract).Result;

            if (result != null && !string.IsNullOrEmpty(result.Token))
                return true;

            return false;
        }

        public async Task<bool> Register(AuthenticationContract contract)
        {
            var settings = await unitOfWork.SystemSettingsRepository.GetSystemSettings(ReqResConstant.reqres);
            var result = httpHelper.PostRequest<
                AuthenticationContract,
                AuthenticationResponseContract>
                (string.Concat(
                    settings.FirstOrDefault(x => x.Key == ReqResConstant.reqresUrl).Value,
                    settings.FirstOrDefault(x => x.Key == ReqResConstant.registerUri).Value),
                contract).Result;

            if (result != null && !string.IsNullOrEmpty(result.Token))
                return true;

            return false;
        }
    }
}
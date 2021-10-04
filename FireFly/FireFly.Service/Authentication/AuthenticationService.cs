using FireFly.Common.Helpers;
using FireFly.Contract.Authentication;
using FireFly.Data;
using FireFly.Data.Repositories.SystemSetting;
using FireFly.Service.SystemSettings;
using System.Linq;
using System.Threading.Tasks;

namespace FireFly.Service.Authentication
{
    public class AuthenticationService
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new FireFlyContext());
        HttpHelper httpHelper;

        public AuthenticationService()
        {
            httpHelper = new HttpHelper();
        }

        public async Task<bool> Login(AuthenticationContract contract)
        {
            var settings =await unitOfWork.SystemSettingsRepository.GetSystemSetting("REQRES");
            var result = httpHelper.PostRequest<
                AuthenticationContract,
                AuthenticationResponseContract>
                (string.Concat(settings.Where(x=> x.Key == "URL"), settings.Where(x => x.Key == "REGISTERURI")), 
                contract).Result;

            if (result != null && !string.IsNullOrEmpty(result.Token))
                return true;

            return false;
        }

        public async Task<bool> Register(AuthenticationContract contract)
        {
            var settings = await unitOfWork.SystemSettingsRepository.GetSystemSetting("REQRES");
            var result = httpHelper.PostRequest<
                AuthenticationContract,
                AuthenticationResponseContract>
                (string.Concat(settings.Where(x => x.Key == "URL"), settings.Where(x => x.Key == "REGISTERURI"), contract);

            if (result != null && !string.IsNullOrEmpty(result.Token))
                return true;

            return false;
        }
    }
}
using FireFly.Data.Repositories.Authentication;
using FireFly.Data.Repositories.SystemSetting;

namespace FireFly.Data
{
    public interface IUnitOfWork
    {
        IAuthenticationRepository AuthenticationRepository { get; }
        ISystemSettingsRepository SystemSettingsRepository { get; }
        int Complate();
    }
}

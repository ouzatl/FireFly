using FireFly.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FireFly.Data.Repositories.SystemSetting
{
    public interface ISystemSettingsRepository : IBaseRepository<SystemSettings>
    {
        Task<IEnumerable<SystemSettings>> GetSystemSettings(string groupKey);

        Task<IEnumerable<SystemSettings>> GetSystemSetting(string key);
    }
}
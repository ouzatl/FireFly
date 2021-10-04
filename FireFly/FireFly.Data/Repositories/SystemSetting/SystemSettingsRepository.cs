using FireFly.Data.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FireFly.Data.Repositories.SystemSetting
{
    public class SystemSettingsRepository : BaseRepository<SystemSettings>, ISystemSettingsRepository
    {
        private readonly DbContext _dbContext;

        public SystemSettingsRepository(FireFlyContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<SystemSettings>> GetSystemSettings(string groupKey)
        {
            //var result = await _dbContext.Set<SystemSettings>()
            //    .Where(x => x.GroupKey == groupKey)
            //    .ToListAsync();

            var systemSettingList = new List<SystemSettings> {
                new SystemSettings { GroupKey = "REQRES", Key = "REQRESURL", Value = "https://reqres.in/" },
                new SystemSettings { GroupKey = "REQRES", Key = "REGISTERURI", Value = "api/register" },
                new SystemSettings { GroupKey = "REQRES", Key = "LOGINURI", Value = "api/login" }
            };
            var result = systemSettingList.Where(x => x.GroupKey == groupKey).ToList();

            return result;
        }

        public async Task<SystemSettings> GetSystemSetting(string key)
        {
            //var result = await _dbContext.Set<SystemSettings>()
            //    .FirstOrDefaultAsync(x => x.GroupKey == key);

            var systemSettingList = new List<SystemSettings> {
                new SystemSettings { GroupKey = "REQRES", Key = "REQRESURL", Value = "https://reqres.in/" },
                new SystemSettings { GroupKey = "REQRES", Key = "REGISTERURI", Value = "api/register" },
                new SystemSettings { GroupKey = "REQRES", Key = "LOGINURI", Value = "api/login" }
            };

            var result = systemSettingList.FirstOrDefault(x => x.Key == key);

            return result;
        }
    }
}
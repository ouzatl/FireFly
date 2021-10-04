using FireFly.Data.Repositories.Authentication;
using FireFly.Data.Repositories.SystemSetting;

namespace FireFly.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private FireFlyContext _context = new FireFlyContext();

        public UnitOfWork(FireFlyContext context)
        {
            _context = context;
            AuthenticationRepository = new AuthenticationRepository(_context);
            SystemSettingsRepository = new SystemSettingsRepository(_context);
        }

        public IAuthenticationRepository AuthenticationRepository { get; private set; }
        public ISystemSettingsRepository SystemSettingsRepository { get; private set; }

        public int Complate()
        {
          return  _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
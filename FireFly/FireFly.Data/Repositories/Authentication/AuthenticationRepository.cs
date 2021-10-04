using System.Data.Entity;

namespace FireFly.Data.Repositories.Authentication
{
    public class AuthenticationRepository : BaseRepository<FireFly.Data.Models.Authentication>, IAuthenticationRepository
    {
        private readonly DbContext _dbContext;

        public AuthenticationRepository(FireFlyContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
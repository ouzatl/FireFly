using FireFly.Data.Repository;
using System.Data.Entity;

namespace FireFly.Data.Repositories.Authentication
{
    public class AuthenticationRepository : BaseRepository<FireFly.Data.Models.Authentication>
    {
        private readonly DbContext _dbContext;

        public AuthenticationRepository(FireFlyContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;

namespace RedisP1.Database.Data.v1
{
    public class Database : IDatabase
    {
        public Task CreateAsync(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<List<IEntity>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEntity>> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}

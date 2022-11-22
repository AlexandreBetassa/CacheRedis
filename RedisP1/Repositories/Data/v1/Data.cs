using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;

namespace RedisP1.Repositories.Data.v1
{
    public class Data : IDatabase<IEntity>
    {
        public Task<ActionResult<IEntity>> CreateAsync(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEntity>> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<List<IEntity>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}

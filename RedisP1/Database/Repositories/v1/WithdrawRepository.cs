using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;

namespace RedisP1.Database.Repositories.v1
{
    public class WithdrawRepository : IRepository
    {
        private readonly IDatabase _data;
        public WithdrawRepository(IDatabase data)
        {
            _data = data;
        }
        public Task CreateAsync(IEntity entity)
        {
            return _data.CreateAsync(entity);
        }

        public Task<ActionResult<List<IEntity>>> GetAllAsync()
        {
            return _data.GetAllAsync();
        }

        public Task<ActionResult<IEntity>> GetAsync(string id)
        {
            return _data.GetAsync(id);
        }
    }
}

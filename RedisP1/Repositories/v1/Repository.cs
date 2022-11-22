using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;

namespace RedisP1.Repositories.v1
{
    public class Repository : IRepository<IEntity>
    {
        private readonly IDatabase<IEntity> _data;
        public Repository(IDatabase<IEntity> data)
        {
            _data = data;
        }

        public Task<ActionResult<IEntity>> CreateAsync(IEntity entity)
        {
            try
            {
                return _data.CreateAsync(entity);
            }
            catch
            {
                throw new Exception();
            }
        }

        public Task<ActionResult<IEntity>> GetAsync(string id)
        {
            try
            {
                return _data.GetAsync(id);
            }
            catch
            {
                throw new Exception();
            }
        }

        public Task<ActionResult<List<IEntity>>> GetAllAsync()
        {
            try
            {
                return _data.GetAllAsync();
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}

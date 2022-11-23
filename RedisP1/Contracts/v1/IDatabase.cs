using Microsoft.AspNetCore.Mvc;

namespace RedisP1.Contracts.v1
{
    public interface IDatabase
    {
        Task CreateAsync(IEntity entity);
        Task<ActionResult<List<IEntity>>> GetAllAsync();
        Task<ActionResult<IEntity>> GetAsync(string id);
    }
}

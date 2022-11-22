using Microsoft.AspNetCore.Mvc;

namespace RedisP1.Contracts.v1
{
    public interface IDatabase<T>
    {
        Task<ActionResult<T>> CreateAsync(T entity);
        Task<ActionResult<List<T>>> GetAllAsync();
        Task<ActionResult<T>> GetAsync(string id);
    }
}

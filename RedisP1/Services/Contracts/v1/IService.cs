using Microsoft.AspNetCore.Mvc;

namespace RedisP1.Services.Contracts.v1
{
    public interface IService<T> where T : class
    {
        Task<ActionResult<T>> Create(T entity);
        Task<ActionResult<T>> Get(String id);
        Task<ActionResult<List<T>>> GetAll();
    }
}

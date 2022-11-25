using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;
using RedisP1.Services.Contracts.v1;

namespace RedisP1.Services.v1
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<ActionResult<T>> Create(T entity)
        {
            return await _repository.CreateAsync(entity);
        }

        public async Task<ActionResult<T>> Get(string id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<ActionResult<List<T>>> GetAll()
        {
            return await _repository.GetAllAsync();
        }
    }
}

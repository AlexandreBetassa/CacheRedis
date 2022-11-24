using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;
using RedisP1.Models.v1;
using RedisP1.Services.Contracts.v1;

namespace RedisP1.Services.v1
{
    public class PixService : IService<Pix>
    {
        private readonly IRepository<Pix> _repository;

        public PixService(IRepository<Pix> repository)
        {
            _repository = repository;
        }

        public async Task<ActionResult<Pix>> Create(Pix entity)
        {
            return await _repository.CreateAsync(entity);
        }

        public async Task<ActionResult<Pix>> Get(string id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<ActionResult<List<Pix>>> GetAll()
        {
            return await _repository.GetAllAsync();
        }
    }
}

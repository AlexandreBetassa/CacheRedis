using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;
using RedisP1.Models.v1;

namespace RedisP1.Services.v1
{
    public class PixService : IStrategy, IRepository<Pix>
    {
        private readonly IRepository<Pix> _repository;

        public PixService(IRepository<Pix> repository)
        {
            _repository = repository;
        }

        public Task<ActionResult<Pix>> CreateAsync(Pix entity)
        {
            try
            {
                return _repository.CreateAsync(entity);
            }
            catch
            {
                throw new Exception();
            }
        }

        public Task<ActionResult<List<Pix>>> GetAllAsync()
        {
            try
            {
                return _repository.GetAllAsync();
            }
            catch
            {
                throw new Exception();
            }
        }

        public Task<ActionResult<Pix>> GetAsync(string id)
        {
            try
            {
                return _repository.GetAsync(id);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}

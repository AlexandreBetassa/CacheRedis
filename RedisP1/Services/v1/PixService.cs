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

        public Task Create(Pix entity)
        {
            return _repository.CreateAsync(entity);
        }

        public Task Get(string id)
        {
            return _repository.GetAsync(id);
        }

        public Task GetAll()
        {
            return _repository.GetAllAsync();
        }
    }
}

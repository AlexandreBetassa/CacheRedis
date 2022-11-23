using RedisP1.Contracts.v1;
using RedisP1.Services.Contracts.v1;

namespace RedisP1.Services.v1
{
    public class DebitCardService : IService
    {
        private readonly IRepository _repository;

        public DebitCardService(IRepository repository)
        {
            _repository = repository;
        }

        public Task CreateAsync(IEntity entity)
        {
            return _repository.CreateAsync(entity);
        }

        public Task GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task GetAsync(string id)
        {
            return _repository.GetAsync(id);
        }
    }
}

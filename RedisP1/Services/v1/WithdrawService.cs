using RedisP1.Contracts.v1;

namespace RedisP1.Services.v1
{
    public class WithdrawService
    {
        private readonly IRepository _repository;

        public WithdrawService(IRepository repository)
        {
            _repository = repository;
        }

        public Task CreateAsync(IEntity entity)
        {
            return _repository.CreateAsync(entity);
        }

        public Task GetAllAsync(IEntity entity)
        {
            return _repository.GetAllAsync();
        }

        public Task GetAsync(string id)
        {
            return _repository.GetAsync(id);
        }
    }
}

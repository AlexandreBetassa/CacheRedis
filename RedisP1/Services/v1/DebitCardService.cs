using RedisP1.Contracts.v1;
using RedisP1.Models.v1;
using RedisP1.Services.Contracts.v1;

namespace RedisP1.Services.v1
{
    public class DebitCardService : IService<DebitCard>
    {
        private readonly IRepository<DebitCard> _repository;

        public DebitCardService(IRepository<DebitCard> repository)
        {
            _repository = repository;
        }

        public Task Create(DebitCard debitCard)
        {
            return _repository.CreateAsync(debitCard);
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

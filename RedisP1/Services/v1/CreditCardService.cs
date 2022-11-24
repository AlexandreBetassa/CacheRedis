using RedisP1.Contracts.v1;
using RedisP1.Models.v1;
using RedisP1.Services.Contracts.v1;

namespace RedisP1.Services.v1
{
    public class CreditCardService : IService<CreditCard>
    {
        private readonly IRepository<CreditCard> _repository;

        public CreditCardService(IRepository<CreditCard> repository)
        {
            _repository = repository;
        }

        public Task Create(CreditCard creditCard)
        {
            return _repository.CreateAsync(creditCard);
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

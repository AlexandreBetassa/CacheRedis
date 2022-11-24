using Microsoft.AspNetCore.Mvc;
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

        public async Task<ActionResult<CreditCard>> Create(CreditCard creditCard)
        {
            return await _repository.CreateAsync(creditCard);

        }

        public async Task<ActionResult<CreditCard>> Get(string id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<ActionResult<List<CreditCard>>> GetAll()
        {
            return await _repository.GetAllAsync();
        }
    }
}

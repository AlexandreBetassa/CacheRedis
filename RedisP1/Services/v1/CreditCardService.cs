using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;
using RedisP1.Models.v1;

namespace RedisP1.Services.v1
{
    public class CreditCardService : IStrategy, IRepository<CreditCard>
    {
        private readonly IRepository<CreditCard> _repository;

        public CreditCardService(IRepository<CreditCard> repository)
        {
            _repository = repository;
        }

        public Task<ActionResult<CreditCard>> CreateAsync(CreditCard entity)
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

        public Task<ActionResult<List<CreditCard>>> GetAllAsync()
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

        public Task<ActionResult<CreditCard>> GetAsync(string id)
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

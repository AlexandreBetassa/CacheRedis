using Microsoft.AspNetCore.Mvc;
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

        public async Task<ActionResult<DebitCard>> Create(DebitCard debitCard)
        {
            return await _repository.CreateAsync(debitCard);
        }

        public async Task<ActionResult<DebitCard>> Get(string id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<ActionResult<List<DebitCard>>> GetAll()
        {
            return await _repository.GetAllAsync();
        }
    }
}

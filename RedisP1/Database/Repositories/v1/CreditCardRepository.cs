using RedisP1.Contracts.v1;
using RedisP1.Models.v1;

namespace RedisP1.Database.Repositories.v1
{
    public class CreditCardRepository : IRepository<CreditCard>
    {
        private readonly IDatabase<CreditCard> _data;

        public CreditCardRepository(IDatabase<CreditCard> data)
        {
            _data = data;
        }

        public async Task<CreditCard> CreateAsync(CreditCard entity)
        {
            return await _data.CreateAsync(entity);

        }

        public async Task<List<CreditCard>> GetAllAsync()
        {
            return await _data.GetAllAsync();
        }

        public async Task<CreditCard> GetAsync(string id)
        {
            return await _data.GetAsync(id);
        }
    }
}

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

        public Task<CreditCard> CreateAsync(CreditCard entity)
        {
            return _data.CreateAsync(entity);

        }

        public Task<List<CreditCard>> GetAllAsync()
        {
            return _data.GetAllAsync();
        }

        public Task<CreditCard> GetAsync(string id)
        {
            return _data.GetAsync(id);
        }
    }
}

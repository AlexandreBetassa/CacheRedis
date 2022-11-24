using RedisP1.Contracts.v1;
using RedisP1.Models.v1;

namespace RedisP1.Database.Repositories.v1
{
    public class DebitCardRepository : IRepository<DebitCard>
    {
        private readonly IDatabase<DebitCard> _data;
        public DebitCardRepository(IDatabase<DebitCard> data)
        {
            _data = data;
        }

        public Task<DebitCard> CreateAsync(DebitCard entity)
        {
            return _data.CreateAsync(entity);
        }

        public Task<List<DebitCard>> GetAllAsync()
        {
            return _data.GetAllAsync();
        }

        public Task<DebitCard> GetAsync(string id)
        {
            return _data.GetAsync(id);
        }
    }
}

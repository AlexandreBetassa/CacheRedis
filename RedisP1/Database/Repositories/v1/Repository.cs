using RedisP1.Contracts.v1;

namespace RedisP1.Database.Repositories.v1
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IDatabase<T> _data;

        public Repository(IDatabase<T> data)
        {
            _data = data;
        }

        public Task<T> CreateAsync(T entity)
        {
            return _data.CreateAsync(entity);
        }

        public Task<List<T>> GetAllAsync()
        {
            return _data.GetAllAsync();
        }

        public Task<T> GetAsync(string id)
        {
            return _data.GetAsync(id);
        }
    }
}

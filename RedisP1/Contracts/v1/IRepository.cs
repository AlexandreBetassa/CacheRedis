namespace RedisP1.Contracts.v1
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(string id);
    }
}

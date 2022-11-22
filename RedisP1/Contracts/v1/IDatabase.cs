namespace RedisP1.Contracts.v1
{
    public interface IDatabase<T> where T : class
    {
        Task CreateAsync(T entity);
        Task GetAll();
        Task Get(string id);
    }
}

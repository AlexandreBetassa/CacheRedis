namespace RedisP1.Contracts.v1
{
    public interface IRepository<T> : IDatabase<T> where T : class
    {
    }
}

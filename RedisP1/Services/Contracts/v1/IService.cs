using RedisP1.Contracts.v1;

namespace RedisP1.Services.Contracts.v1
{
    public interface IService
    {
        Task CreateAsync(IEntity entity);
        Task GetAsync(string id);
        Task GetAllAsync();
    }
}

using RedisP1.Models.v1;

namespace RedisP1.Services.Contracts.v1
{
    public interface IService<T> where T : class
    {
        Task Create(T creditCard);
        Task Get(String id);
        Task GetAll();
    }
}

using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;
using RedisP1.Models.v1;

namespace RedisP1.Database.Repositories.v1
{
    public class PixRepository : IRepository<Pix>
    {
        private readonly IDatabase<Pix> _data;
        public PixRepository(IDatabase<Pix> data)
        {
            _data = data;
        }

        public Task<Pix> CreateAsync(Pix entity)
        {
            return _data.CreateAsync(entity);
        }

        public Task<List<Pix>> GetAllAsync()
        {
            return _data.GetAllAsync();
        }

        public Task<Pix> GetAsync(string id)
        {
            return _data.GetAsync(id);
        }
    }
}

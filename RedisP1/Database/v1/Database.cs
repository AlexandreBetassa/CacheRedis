using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using RedisP1.Contracts.v1;
using RedisP1.Models.v1;
using System.Text.Json;

namespace RedisP1.Database.v1
{
    public class Database<T> : IDatabase<T> where T : class
    {
        private readonly AppDbContext _db;
        private readonly IDistributedCache _cache;
        public Database(AppDbContext db, IDistributedCache cache)
        {
            _db = db;
            _cache = cache;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            await _cache.RemoveAsync(typeof(T).Name);
            return await Task.FromResult(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {

            var entityJson = await _cache.GetStringAsync(typeof(T).Name);
            if (entityJson != null)
            {
                var entity = JsonSerializer.Deserialize<List<T>>(entityJson);
                return entity;
            }
            else
            {
                var entity = _db.Set<T>().ToList();
                string jsonEntity = JsonSerializer.Serialize(entity);
                await _cache.SetStringAsync(typeof(T).Name, jsonEntity);
                return entity;
            }
        }

        public async Task<T> GetAsync(string id)
        {
            var entity = await _cache.GetStringAsync(typeof(T).Name + id);
            if (entity != null)
            {
                return JsonSerializer.Deserialize<T>(entity);
            }
            else
            {
                var entityObj = await _db.Set<T>().FindAsync(id);
                var entityJson = JsonSerializer.Serialize<T>(entityObj);
                await _cache.SetStringAsync(typeof(T).Name + id, entityJson);
                return entityObj;
            }
        }
    }
}

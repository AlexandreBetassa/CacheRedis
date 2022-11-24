using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedisP1.Contracts.v1;

namespace RedisP1.Database.v1
{
    public class Database<T> : IDatabase<T> where T : class
    {
        private readonly AppDbContext _db;
        public Database(AppDbContext db)
        {
            _db = db;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(string id)
        {
            return await _db.Set<T>().FindAsync(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;
using RedisP1.Models.v1;

namespace RedisP1.Services.v1
{
    public class WithdrawService : IStrategy, IRepository<Withdraw>
    {
        private readonly IRepository<Withdraw> _repository;

        public WithdrawService(IRepository<Withdraw> repository)
        {
            _repository = repository;
        }

        public Task<ActionResult<Withdraw>> CreateAsync(Withdraw entity)
        {
            try
            {
                return _repository.CreateAsync(entity);
            }
            catch
            {
                throw new Exception();
            }
        }

        public Task<ActionResult<List<Withdraw>>> GetAllAsync()
        {
            try
            {
                return _repository.GetAllAsync();
            }
            catch
            {
                throw new Exception();
            }
        }

        public Task<ActionResult<Withdraw>> GetAsync(string id)
        {
            try
            {
                return _repository.GetAsync(id);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}

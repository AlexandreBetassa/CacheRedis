using Microsoft.AspNetCore.Mvc;
using RedisP1.Contracts.v1;
using RedisP1.Models.v1;
using RedisP1.Services.Contracts.v1;

namespace RedisP1.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IEnumerable<IService> _service;

        public ProductsController(IEnumerable<IService> service)
        {
            _service = service;
        }

        [HttpPost]
        public Task Create(String type, CreditCard entity)
        {
            return _service.Where(service => service.GetType().Name.Contains(type)).First().CreateAsync(entity);
        }

        [HttpGet]
        public Task Get(string type)
        {
            return _service.Where(service => service.GetType().Name.Contains(type)).First().GetAllAsync();
        }
    }
}

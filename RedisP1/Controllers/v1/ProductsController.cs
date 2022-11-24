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
        private readonly IService<CreditCard> _service;

        public ProductsController(IService<CreditCard> service)
        {
            _service = service;
        }

        [HttpPost]
        public Task Create(String type, CreditCard entity)
        {
            return _service.Create(entity);
        }

        //[HttpGet]
        //public Task Get(string type)
        //{
        //    return _service.Where(service => service.GetType().Name.Contains(type)).First().GetAll();
        //}
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using RedisP1.Models.v1;
using RedisP1.Services.Contracts.v1;
using System.Text.Json;

namespace RedisP1.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly IService<CreditCard> _service;

        public CreditCardController(IService<CreditCard> service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<CreditCard>> Create(CreditCard entity)
        {
            await _service.Create(entity);
            return CreatedAtRoute("GetOneCreditCard", new { id = entity.Id }, entity);
        }

        [HttpGet]
        public async Task<ActionResult<List<CreditCard>>> Get()
        {
            return await _service.GetAll();
        }

        [HttpGet("{id}", Name = "GetOneCreditCard")]
        public async Task<ActionResult<CreditCard>> Get(string id)
        {
            return await _service.Get(id);
        }
    }
}

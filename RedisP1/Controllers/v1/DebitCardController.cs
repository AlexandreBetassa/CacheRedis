using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedisP1.Models.v1;
using RedisP1.Services.Contracts.v1;

namespace RedisP1.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebitCardController : ControllerBase
    {
        private readonly IService<DebitCard> _service;

        public DebitCardController(IService<DebitCard> service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ActionResult<DebitCard>> Create(DebitCard entity)
        {
            await _service.Create(entity);
            return CreatedAtRoute("GetOneDebitCard", new { id = entity.Id }, entity);
        }

        [HttpGet]
        public async Task<ActionResult<List<DebitCard>>> Get()
        {
            return await _service.GetAll();
        }

        [HttpGet("{id}", Name = "GetOneDebitCard")]
        public async Task<ActionResult<DebitCard>> Get(string id)
        {
            return await _service.Get(id);
        }
    }
}

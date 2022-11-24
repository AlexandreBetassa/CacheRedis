using Microsoft.AspNetCore.Mvc;
using RedisP1.Models.v1;
using RedisP1.Services.Contracts.v1;

namespace RedisP1.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class PixController : ControllerBase
    {
        private readonly IService<Pix> _service;

        public PixController(IService<Pix> service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Pix>> Create(Pix entity)
        {
            await _service.Create(entity);
            return CreatedAtRoute("GetOnePix", new { id = entity.Id }, entity);
        }

        [HttpGet]
        public async Task<ActionResult<List<Pix>>> Get()
        {
            return await _service.GetAll();
        }

        [HttpGet("{id}", Name = "GetOnePix")]
        public async Task<ActionResult<Pix>> Get(string id)
        {
            return await _service.Get(id);
        }
    }
}

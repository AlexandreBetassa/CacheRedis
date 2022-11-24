using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using RedisP1.Contracts.v1;
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
        private readonly IDistributedCache _cache;

        public CreditCardController(IService<CreditCard> service, IDistributedCache cache)
        {
            _service = service;
            _cache = cache;
        }

        [HttpPost]
        public async Task<ActionResult<CreditCard>> Create(CreditCard entity)
        {
            await _service.Create(entity);
            await _cache.RemoveAsync("CreditsCard");
            return CreatedAtRoute("GetOneCreditCard", new { id = entity.Id }, entity);
        }

        [HttpGet]
        public async Task<ActionResult<List<CreditCard>>> Get()
        {
            var creditsJson = await _cache.GetStringAsync("CreditsCard");
            if (creditsJson != null)
            {
                var credits = JsonSerializer.Deserialize<List<CreditCard>>(creditsJson);
                return credits;
            }
            else
            {
                var credits = await _service.GetAll();
                string jsonCredits = JsonSerializer.Serialize<List<CreditCard>>(credits.Value);
                await _cache.SetStringAsync("CreditsCard", jsonCredits);
                return credits;
            }
        }

        [HttpGet("{id}", Name = "GetOneCreditCard")]
        public async Task<ActionResult<CreditCard>> Get(string id)
        {
            var creditsJson = await _cache.GetStringAsync("CreditsCard");
            if (creditsJson != null)
            {
                var credits = JsonSerializer.Deserialize<List<CreditCard>>(creditsJson);
                return credits.Where(creditCard => creditCard.Id == id).FirstOrDefault();
            }
            else
            {
                var credits = await _service.Get(id);
                string jsonCredits = JsonSerializer.Serialize<CreditCard>(credits.Value);
                await _cache.SetStringAsync("CreditsCard", jsonCredits);
                return credits;
            }
        }
    }
}

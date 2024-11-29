using FinanceManager.Server.Data.DTOs;
using FinanceManager.Server.Services.Implementations;
using FinanceManager.Server.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EachPurchaseController : ControllerBase
    {
        private readonly IEachPurchaseService _eachPurchaseService;

        public EachPurchaseController(IEachPurchaseService eachPurchaseService)
        {
            _eachPurchaseService = eachPurchaseService;
        }

        [HttpPost]
        public async Task<IActionResult> PostEachPurchase(EachPurchaseDTO eachPurchaseDTO)
        {
            var createEachPurchase = await _eachPurchaseService.PostEachPurchase(eachPurchaseDTO);
            return CreatedAtAction(nameof(GetEachPurchaseById), new { id = createEachPurchase.Id }, createEachPurchase);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEachPurchase( EachPurchaseDTO eachPurchaseDTO, int id)
        {
            var updateEachPurchase = await _eachPurchaseService.UpdateEachPurchase(eachPurchaseDTO, id);
            return Ok(updateEachPurchase);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEachPurchase(int id)
        {
            var deleteEachPurchase = await _eachPurchaseService.DeleteEachPurchase(id);
            return Ok(deleteEachPurchase);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEachPurchase()
        {
            var allEachPurchase = await _eachPurchaseService.GetAllEachPurchase();
            return Ok(allEachPurchase);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEachPurchaseById(int id)
        {
            var eachPurchaseId = await _eachPurchaseService.GetEachPurchaseById(id);
            return Ok(eachPurchaseId);
        }
    }
}

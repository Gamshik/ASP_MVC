using Contracts.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MVCApp.Controllers
{
    [Route("settlements")]
    public class SettlementController : Controller
    {
        private readonly ISettlementRepository _settlementRepository;

        public SettlementController(ISettlementRepository settlementRepository)
        {
            _settlementRepository = settlementRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var test = _settlementRepository.GetAll();
            var allSettlements = new StringBuilder("");
            foreach (var item in test)
            {
                allSettlements.Append($"Is {item.Id} title: {item.Title}\n");
            }
            return Ok(allSettlements.ToString());
        }
    }
}

using Contracts.Repositories;
using Contracts.Repositoriesz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MVCApp.Controllers
{
    [Route("routes")]
    public class RouteController : Controller
    {
        private readonly IRouteRepository _routeRepository;

        public RouteController(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var test = _routeRepository.GetAll();
            var allRoutes = new StringBuilder("");
            foreach (var item in test)
            {
                allRoutes.Append($"Is {item.Id} start: {item.StartSettlementId} end: {item.EndSettlementId}\n");
            }
            return Ok(allRoutes.ToString());
        }
    }
}

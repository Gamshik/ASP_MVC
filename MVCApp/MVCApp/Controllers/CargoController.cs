using Contracts.Repositoriesz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.Diagnostics;
using System.Text;

namespace MVCApp.Controllers
{
    [Route("cargos")]
    public class CargoController : Controller
    {
        private readonly ICargoRepository _cargoRepository;

        public CargoController(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var test = _cargoRepository.GetAll();
            var allCargos = new StringBuilder("");
            foreach (var item in test)
            {
                allCargos.Append($"Weight {item.Weight} Id: {item.Id} REG: {item.RegistrationNumber}\n");
            }
            return Ok(allCargos.ToString());
        }
    }
}

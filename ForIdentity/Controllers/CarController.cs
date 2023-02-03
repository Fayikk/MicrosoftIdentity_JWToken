using ForIdentity.Base.Abstract;
using ForIdentity.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CarController : ControllerBase
    {
        ICarService<Car> _carService; 
        public CarController(ICarService<Car> carService)
        {
            _carService = carService;   
        }

        [HttpGet]
        public IActionResult GetAllCar()
        {
          var result =  _carService.GetAll();
            
            if(result == null)
            {
                return BadRequest("Eleman bulunamadı");
            }
            else
            {
            return Ok(result);

            }
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        public IActionResult AddCar(Car item)
        {
            _carService.Add(item);
            return Ok();
        }




    }
}

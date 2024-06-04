using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetEDDY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(Storage.Dog.ToList());

        [HttpPost]
        public IActionResult Post([FromBody] Dog model)
        {
            Storage.Dog.Add(model);
            
            return Accepted();
        }
    }
}

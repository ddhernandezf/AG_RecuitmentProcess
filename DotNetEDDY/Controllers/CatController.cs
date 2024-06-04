using Microsoft.AspNetCore.Mvc;

namespace DotNetEDDY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(Storage.Cat.ToList());

        [HttpPost]
        public IActionResult Post([FromBody] Cat model)
        {
            Storage.Cat.Add(model);

            return Accepted();
        }
    }
}

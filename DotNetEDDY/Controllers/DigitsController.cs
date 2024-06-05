using Microsoft.AspNetCore.Mvc;

namespace DotNetEDDY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DigitsController : ControllerBase
    {
        private static int[] data = Enumerable.Range(1,100).ToArray();

        [HttpGet]
        public IActionResult Get() => Ok(data);
    }
}

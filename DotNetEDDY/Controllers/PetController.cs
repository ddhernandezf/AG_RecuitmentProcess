using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DotNetEDDY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new List<IPet>().Concat(Storage.Dog).Concat(Storage.Cat));

        [HttpGet("total")]
        public IActionResult Total() => Ok(new StringBuilder()
                .AppendLine($"Pet Totals: {new List<IPet>().Concat(Storage.Dog).Concat(Storage.Cat).ToList().Count}")
                .AppendLine($"Dog Totals: {Storage.Dog.Count}")
                .AppendLine($"Cat Totals: {Storage.Cat.Count}")
                .ToString());
    }
}

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
        public IActionResult Total()
        {
            List<IPet> pets = Storage.Dog;
            pets.AddRange(Storage.Cat);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pet Totals: {pets.Count}");
            sb.AppendLine($"Dog Totals: {Storage.Dog.Count}");
            sb.AppendLine($"Cat Totals: {Storage.Cat.Count}");

            return Ok(sb.ToString());
        }
    }
}

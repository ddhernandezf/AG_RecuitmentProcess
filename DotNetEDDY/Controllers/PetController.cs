using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DotNetEDDY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<IPet> result = new List<IPet>();
            result.AddRange(Storage.Cat);
            result.AddRange(Storage.Dog);

            return Ok(result);
        }

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

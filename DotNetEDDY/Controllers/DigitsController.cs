using Microsoft.AspNetCore.Mvc;

namespace DotNetEDDY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DigitsController : ControllerBase
    {
        private static List<int> data = Enumerable.Range(1, 100).ToList();

        [HttpGet]
        public IActionResult Get() => Ok(new { count = data.Count, data });

        [HttpGet("test")]
        public IActionResult Post()
        {
            List<int> toBeRemoved = GetRandom();

            data = data.Where(x => !toBeRemoved.Contains(x)).ToList();


            return Ok(new { coutn = data.Count, removed = toBeRemoved, data});
        }

        private List<int> GetRandom()
        {
            Random numbers = new Random(Guid.NewGuid().GetHashCode());
            int minor = data.Order().FirstOrDefault();
            int major = data.OrderByDescending(x => x).FirstOrDefault();

            return new List<int>()
            {
                numbers.Next(minor, major),
                numbers.Next(minor, major),
                numbers.Next(minor, major)
            };
        }
    }
}

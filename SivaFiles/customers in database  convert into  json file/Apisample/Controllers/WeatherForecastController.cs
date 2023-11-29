using Apisample.Dbcontact;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Apisample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
    private readonly contactAPIDbcontext _contactAPIDbcontext;
      
        public WeatherForecastController(contactAPIDbcontext contactAPIDbcontext)
        {
            _contactAPIDbcontext = contactAPIDbcontext;
        }

        [HttpGet("Getname")]
        public async Task <IActionResult> Getname()
        {
            var rep = await _contactAPIDbcontext.Customers.ToListAsync();
            return Ok(rep);
        }
    }
}
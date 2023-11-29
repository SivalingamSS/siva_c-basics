using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sampleapi.Dbcontact;

namespace Sampleapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
         private readonly Dbclass _dbclass;
        public WeatherForecastController(Dbclass dbclass)
        {
            _dbclass = dbclass;
        }
        [HttpGet("Gethospital")]
        public async Task <IActionResult> Gethospital()
        {
            try
            {
                var rep = await _dbclass.hospital.ToListAsync();
                return Ok(rep);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}
using Microsoft.AspNetCore.Mvc;
using crud_model.modal;
using crud_model.Dbcontact;
using Microsoft.EntityFrameworkCore;
using crud_model.Viewmodel;

namespace crud_model.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DbContact _DbContact;

        public WeatherForecastController(DbContact Dbcontact)
        {
            _DbContact = Dbcontact;
        }
        [HttpGet("Getfactory")]
        public async Task<IActionResult> Getfactory()
        {
            var ert = await _DbContact.Factory.ToListAsync();
            return Ok(ert);
        }
        [HttpPost]
        public async Task<IActionResult> Addmodel(model addContactRequest)
        {
            var rep = new model()
            {
                id = addContactRequest.id,
                name = addContactRequest.name,
                age = addContactRequest.age,
                email = addContactRequest.email,

            };
            await _DbContact.Factory.AddAsync(rep);
            await _DbContact.SaveChangesAsync();
            return Ok(rep);
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, Viewmodal call)
        {
            var rep = await _DbContact.Factory.FindAsync(id);
            if (rep != null)
            {
                //rep.age = call.age;
                rep.email = call.email;
                rep.name = call.name;
                await _DbContact.SaveChangesAsync();
                return Ok(rep);
            }
            return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id,Viewmodal res)
        {
            var repp = await _DbContact.Factory.FindAsync(id);
            if (repp != null)
            {
                _DbContact.Remove(repp);
                _DbContact.SaveChanges();
                return Ok(repp);
            }
            return BadRequest();
        }
    }
}
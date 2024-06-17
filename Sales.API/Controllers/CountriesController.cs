using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.API.Data;
using Sales.Shared.Entities;

namespace Sales.API.Controllers
{
    [ApiController]
    [Route("api/countries")]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _context; 
        public CountriesController(DataContext context)
        {
            _context = context;
        }


        
        [HttpPost]
        public async Task<ActionResult> PostAsync(Country country)
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);

        }

        //Método GET
        
        [HttpGet]
        public async Task <IActionResult> GetAsync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }

        //Metodo Put
        [HttpPut]
        public async Task<ActionResult> PutAsync(Country country)
        {
            _context.Update(country);
            await _context.SaveChangesAsync();
            return Ok(country);
        }

        //Metodo GET
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(x=> x.Id == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        //Metodo Delete
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(x => x.Id == id);
            if(country == null)
            { 
                return NotFound();
            }

            _context.Remove(country);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

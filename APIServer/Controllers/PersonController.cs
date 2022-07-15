using APIServer.Data;
using APIServer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public readonly ApplicationDbContext db;

        public PersonController(ApplicationDbContext db)
        {
            this.db = db;

        }

        [HttpPost("CreatePerson")]
        public async Task<Object> CreatePerson(Person person)
        {
            try
            {
                await db.Persons.AddAsync(person);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        [HttpGet("GetAllPerson")]
        public IEnumerable<Person> GetAllPerson()
        {
            try
            {
               return  db.Persons.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}

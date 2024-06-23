using Microsoft.AspNetCore.Mvc;
using RotaAPI.Models;
using RotaAPI.DataAccessLayer;
using System.Data.Entity;

namespace RotaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly RotaDbContext _context;

        private Authentication auth = new Authentication();

        List<Person> happy = new List<Person>
        {
            new Person
            {
                id = 1,
                first_name = "Joe",
                last_name = "Banson",
                address = "43 Kingsley Street",
                city = "London",
                date_of_birth = new DateTime(2023,12,21),
                user_active_ind = 'Y',
                role_ind = 'D',
                health_dec_ind = 'Y',
                employment_his = 'Y'

            },
            new Person
            {
                id = 2,
                first_name = "Joes",
                last_name = "Banson",
                address = "43 Kingsley Street",
                city = "London",
                date_of_birth = new DateTime(1995,10,28),
                user_active_ind = 'Y',
                role_ind = 'D',
                health_dec_ind = 'Y',
                employment_his = 'Y'

            },
            new Person
            {
                id = 3,
                first_name = "Joe",
                last_name = "Banson",
                address = "43 Kingsley Street",
                city = "London",
                date_of_birth = new DateTime(2023,12,01),
                user_active_ind = 'Y',
                role_ind = 'D',
                health_dec_ind = 'Y',
                employment_his = 'Y'

            }
        };
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        public PersonController(RotaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)  
        {
                var person = await _context.people.Where(x => x.id == id).FirstOrDefaultAsync();

                if (string.IsNullOrEmpty(person.first_name))
                {
                    return NotFound();
                }
         
            return (IActionResult)person;

            //return Ok();
            //var authResult = auth.AuthenticatePerson(person_id);

            //if (authResult == true)
            //{
            //    try
            //    {
            //        return happy[person_id - 1] == null ? NotFound() : Ok(happy[person_id - 1]);
            //    }
            //    catch (Exception e)
            //    {
            //        throw new Exception("Invalid Operation");
            //    }
            //}
            //else
            //{ 
            //    return NotFound();
            //}
        }

        [HttpPost]
        public async Task<ActionResult<Person>> Post(Person person)
        {
            _context.people.AddRange(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new {id = person.id },person);
        }

        [HttpPut("{Person}")]
        public string Put(Person person)
        {
            return "completed";
        }

        [HttpDelete("{id}")]
        public string Delete(int person_id)
        {
            happy.Remove(happy[person_id-1]);
            return "completed";
        }
    }
}

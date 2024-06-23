using Microsoft.AspNetCore.Mvc;
using System.Net.Security;
using UndergroundAPI.Models.Entities;

namespace UndergroundAPI.Controllers
{
    [ApiController]
    [Route("TrainController")]
    public class TrainController : Controller
    {
        [HttpPost("CreateTrain")]
        public static void CreatTrain(Train item)
        {
            using (var context = new TrainDbContext())
            {
                context.Trains.Add(
                new Train
                {
                    Name = item.Name,
                    Description = item.Description,
                    Carriages = item.Carriages
                });
                context.SaveChanges();
            }
        }

        [HttpGet("GetTrain")]
        public async Task<IActionResult> GetTrain(int id)
        {
                return Ok("hello");
        }
    }
}

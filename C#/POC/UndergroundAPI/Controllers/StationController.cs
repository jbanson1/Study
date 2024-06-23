using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UndergroundAPI.Models.Entities;

namespace UndergroundAPI.Controllers
{
    [Route("StationController")]
    [ApiController]
    public class StationController : Controller
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
    }
}

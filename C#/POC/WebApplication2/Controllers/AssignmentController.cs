using Microsoft.AspNetCore.Mvc;
using RotaAPI.Models;

namespace RotaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AssignmentController
    {
        [HttpGet]
        public string Get(bool sweety)
        {
            return sweety? "Baki" : "BBK";
        }
    }
}

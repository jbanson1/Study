using Microsoft.AspNetCore.Mvc;
using RotaAPI.Models;

namespace RotaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CertificationController
    {
        List<Certification> certExample = new List<Certification>();
        private readonly ILogger<CertificationController> _logger;

        public CertificationController(ILogger<CertificationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Certification Get(int certification_id)
        {
            var result = certExample[certification_id - 1];

            return result;
        }

        [HttpPost]
        public Certification Post([FromForm] Certification certification)
        {
            certExample.Add(certification);

            return certExample[certExample.Count - 1];
        }

        [HttpPut]
        public string Put([FromForm] Certification certification)
        {


            return "completed";
        }

        [HttpDelete]
        public string Delete(int certification_id)
        {


            return "completed";
        }
    }
}

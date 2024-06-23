using Microsoft.AspNetCore.Mvc;
using RotaAPI.Models;

namespace RotaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        List<Client> clientExample = new List<Client>();
        private readonly ILogger<ClientController> _logger;

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Client Get(int client_id)
        {
            var result = clientExample[client_id - 1];

            return result;
        }

        [HttpPost]
        public Client Post([FromForm] Client client)
        {
            clientExample.Add(client);

            return clientExample[clientExample.Count - 1];
        }

        [HttpPut]
        public string Put([FromForm] Client client)
        {


            return "completed";
        }

        [HttpDelete]
        public string Delete(int client_id)
        {


            return "completed";
        }
    }
}

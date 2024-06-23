using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace RotaAPI.Models
{
    [Keyless]
    public class Client
    {
        public int id { get; set; }
        public string client_name { get; set;}
        public string address { get; set;}
        public DateTime Acquired_dt { get; set; }
        public char client_active { get; set; }
    }
}

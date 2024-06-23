using Microsoft.Build.Framework;

namespace RotaAPI.Models
{
    public class Certification
    {
        [Required]
        public int id { get; set; }
        public int person_id { get; set; }
        public string certification_name { get; set; }
        public DateTime acquired_dt { get; set; }
        public DateTime expired_dt { get; set; }
        public char certification_active_ind { get; set; }
    }
}

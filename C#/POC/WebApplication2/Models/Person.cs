using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.Runtime.InteropServices;

namespace RotaAPI.Models
{
    public class Person
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string? home_number { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public DateTime date_of_birth { get; set; }
        public char user_active_ind { get; set; }
        public char role_ind { get; set; }
        public char health_dec_ind { get; set; }
        public char employment_his { get; set; }
    }
}

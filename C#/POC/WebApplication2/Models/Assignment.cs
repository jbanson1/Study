namespace RotaAPI.Models
{
    public class Assignment  
    {
        public int id {get;set;}
        public int client_id { get;set;}
        public DateTime assignment_dt { get;set;}
        public DateTime? hours_onsite { get; set;}
        public DateTime start_time { get; set;}
        public DateTime? end_time { get; set;}
        public char? completed_ind { get; set;}
        public char? late_ind { get; set;}
        public string? comments { get; set;}
        public int person_id { get; set;}
    }
}

using System.ComponentModel.DataAnnotations;

namespace OrganizingСoncerts_Classes
{
    public class InvolvementOfConcertEmployee
    {
        [Key]
        public int InvolvementOfConcertEmployeeId { get; set; }
        public int ConcertEmployeeId { get; set; }
        public int ConcertId { get; set; }
        public int WorkingTime { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace OrganizingСoncerts_Classes
{
    public class ConcertEmployee
    {
        [Key]
        public int ConcertEmployeeId { get; set; }
        public string? FullNameOfEmployee { get; set; }
        public string? Specialty { get; set; }
        public string? Qualifications { get; set; }
        public int WorkExperience { get; set; }
        public decimal Salary { get; set; }
        public string? PhoneNumber { get; set; }
    }
}

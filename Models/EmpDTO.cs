using System.ComponentModel.DataAnnotations;

namespace PulseTask.Models
{
    public class EmpDTO
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Phone]
        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}

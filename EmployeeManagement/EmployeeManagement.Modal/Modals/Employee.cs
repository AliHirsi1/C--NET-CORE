using EmployeeManagement.Modal.Enum;
using System.ComponentModel.DataAnnotations;


namespace EmployeeManagement.Modal.Modals
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string Email { get; set; }
        public Department Department { get; set; }
        public string EmpImageLocation { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace EmployeeCrudAPI.Model.DTO
{
    /// <summary>
    /// DTO for adding a new employee.
    /// Contains required fields: Name, Designation, and Age.
    /// </summary>
    public class AddEmployeeDtocs
    {
        /// <summary>
        /// Full name of the employee.
        /// </summary>
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Job title or position of the employee.
        /// </summary>
        [Required(ErrorMessage = "Designation is required")]
        [MaxLength(50)]
        public string Designation { get; set; }

        /// <summary>
        /// Age of the employee (must be between 18 and 65).
        /// </summary>
        [Required(ErrorMessage = "Age is required")]
        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65")]
        public int  Age { get; set; }
    }
}

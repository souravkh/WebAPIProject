using System.ComponentModel.DataAnnotations;

namespace EmployeeCrudAPI.Model.Domain
{
    /// <summary>
    /// Domain model representing an employee entity.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Unique identifier for the employee.
        /// </summary>
        [Key]
        public Guid EmployeeId { get; set; }

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
        /// Age of the employee as a string (recommended: use int).
        /// </summary>
        [Required(ErrorMessage = "Age is required")]
        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65")]
        public int Age { get; set; }
    }
}

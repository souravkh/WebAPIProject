using EmployeeCrudAPI.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrudAPI.Data
{
    /// <summary>
    /// Represents the database context for managing employees.
    /// Inherits from DbContext to interact with the database.
    /// </summary>
    public class EmployeeDbDataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDbDataContext"/> class.
        /// </summary>
        /// <param name="dbContextOptions">Options to configure the database context.</param>
        public EmployeeDbDataContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{Employee}"/> representing the Employees table in the database.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
    }
}

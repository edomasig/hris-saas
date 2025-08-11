using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class Company
    {
       public Guid Id { get; set; } // Primary Key

        public string Name { get; set; } = default!;

        public string? Description { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? Website { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        public ICollection<Department> Departments { get; set; } = new List<Department>();

        public ICollection<Employee> Employees { get; set; } = new List<Employee>(); 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

         public string? Description { get; set; }

        public Guid CompanyId { get; set; } // FK

        public ICollection<Position> Positions { get; set; } = new List<Position>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
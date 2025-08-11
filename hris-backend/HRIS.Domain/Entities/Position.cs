using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class Position
    {
         public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal BasicSalary { get; set; }

       public Department Department { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
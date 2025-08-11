using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRIS.Domain.Enums;

namespace HRIS.Domain.Entities
{
    public class AttendanceRecord
    {
         public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime Date { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public AttendanceStatus Status { get; set; }
    }
}
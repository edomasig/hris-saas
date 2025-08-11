using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRIS.Domain.Enums;

namespace HRIS.Domain.Entities
{
    public class LeaveRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; } = string.Empty;
        public LeaveStatus LeaveStatus { get; set; }

        public LeaveType LeaveType { get; set; }
        
    }
}
using HRIS.Domain.Enums;

namespace HRIS.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; } = default!;

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public virtual UserAccount? UserAccount { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }

        public ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();
        
        public ICollection<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
    }
}
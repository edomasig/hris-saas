using HRIS.Domain.Enums;

namespace HRIS.Domain.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime Date { get; set; }
        public AttendanceStatus Status { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
    }
}
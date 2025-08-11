using HRIS.Domain.Enums;

namespace HRIS.Domain.Entities
{
    public class Payroll
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public PayrollFrequency PayrollFrequency { get; set; }
        public decimal BasicPay { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetPay { get; set; } 

        public PayrollStatus PayrollStatus { get; set; } // Enum property
        
    }
}
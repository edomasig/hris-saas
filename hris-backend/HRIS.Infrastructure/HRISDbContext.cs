using Microsoft.EntityFrameworkCore;
using HRIS.Domain.Entities;
using HRIS.Domain.Enums;

namespace HRIS.Infrastructure.Persistence
{
    public class HRISDbContext : DbContext
    {
        public HRISDbContext(DbContextOptions<HRISDbContext> options) : base(options) { }

        // DbSets for Entities
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Company> Companies { get; set; }

        public DbSet<AttendanceRecord> AttendanceRecords { get; set; } // Added

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Employee - Department
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee - Position
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Position)
                .WithMany(p => p.Employees)
                .HasForeignKey(e => e.PositionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee - Company
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Company)
                .WithMany(c => c.Employees)
                .HasForeignKey(e => e.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // Attendance - Employee
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Employee)
                .WithMany(e => e.Attendances)
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // LeaveRequest - Employee
            modelBuilder.Entity<LeaveRequest>()
                .HasOne(l => l.Employee)
                .WithMany(e => e.LeaveRequests)
                .HasForeignKey(l => l.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Payroll - Employee
            modelBuilder.Entity<Payroll>()
                .HasOne(p => p.Employee)
                .WithMany(e => e.Payrolls)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // AttendanceRecord - Employee (new)
            modelBuilder.Entity<AttendanceRecord>()
                .HasOne(r => r.Employee)
                .WithMany(e => e.AttendanceRecords)
                .HasForeignKey(r => r.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // UserAccount - Employee (Optional)
            modelBuilder.Entity<UserAccount>()
                .HasOne(u => u.Employee)
                .WithOne(e => e.UserAccount)
                .HasForeignKey<UserAccount>(u => u.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Enum conversions
            modelBuilder.Entity<Employee>()
                .Property(e => e.EmploymentStatus)
                .HasConversion<string>();

            modelBuilder.Entity<LeaveRequest>()
                .Property(l => l.LeaveStatus)
                .HasConversion<string>();

            modelBuilder.Entity<LeaveRequest>()
                .Property(l => l.LeaveType)
                .HasConversion<string>();

            modelBuilder.Entity<Payroll>()
                .Property(p => p.PayrollStatus)
                .HasConversion<string>();
        }
    }
}

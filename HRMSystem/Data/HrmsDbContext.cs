using HRMSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMSystem.Data
{
    public class HrmsDbContext : DbContext
    {
        public HrmsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Attendance> Attendances { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
       
        {
            // Employee -> Department (Many-to-One)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull);

            // Department -> HRManager (One-to-One with Employee)
            modelBuilder.Entity<Department>()
                .HasOne(d => d.HRManager)
                .WithMany()
                .HasForeignKey(d => d.HRManagerId)
                .OnDelete(DeleteBehavior.SetNull);

            // Attendance -> Employee (Many-to-One)
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Employee)
                .WithMany(e => e.Attendances)
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Leave -> Employee (Many-to-One)
            modelBuilder.Entity<Leave>()
                .HasOne(l => l.Employee)
                .WithMany(e => e.Leaves)
                .HasForeignKey(l => l.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Payroll -> Employee (Many-to-One)
            modelBuilder.Entity<Payroll>()
                .HasOne(p => p.Employee)
                .WithMany(e => e.Payrolls)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

    }
}


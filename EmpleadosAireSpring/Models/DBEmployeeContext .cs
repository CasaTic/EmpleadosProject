using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace EmpleadosAireSpring.Models
{
    public partial class DBEmployeeContext: DbContext
    {
        //Constructor vacío parainicializar
        public DBEmployeeContext()
        {
        }
        public DBEmployeeContext(DbContextOptions<DBEmployeeContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");

                entity.Property(employee => employee.EmployeeID)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(employee => employee.EmployeeLastName).HasMaxLength(250);

                entity.Property(employee => employee.EmployeeFirstName).HasColumnName("EmployeeFirstName");
                entity.Property(employee => employee.EmployeeFirstName).HasMaxLength(250);
                entity.Property(employee => employee.EmployeePhone).HasColumnName("EmployeePhone");
                entity.Property(employee => employee.EmployeePhone).HasMaxLength(20);
                entity.Property(employee => employee.EmployeeZip).HasColumnName("EmployeeZip");
                entity.Property(employee => employee.EmployeeZip).HasMaxLength(10);
                entity.Property(employee => employee.HireDate).HasColumnName("HireDate");

            });
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
    
}

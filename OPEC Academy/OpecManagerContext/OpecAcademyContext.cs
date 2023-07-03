using Microsoft.EntityFrameworkCore;
using OPEC_Academy_API.Models;
using OpecDataBase.DAL.Models;
using System.Diagnostics;
using System.Reflection.Emit;

namespace OpecDataBase.DAL
{
    public class OpecAcademyContext : DbContext
    {
        public OpecAcademyContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent api
            modelBuilder.Entity<Employee>()
                .HasOne(s => s.Branch)
                .WithMany(s => s.Employees)
                .HasForeignKey(s => s.BranchId);

            modelBuilder.Entity<Employee>()
               .HasOne(s => s.Branch_Mng)
               .WithOne(s => s.Supervisor)
               .HasForeignKey<Branch>(s => s.Supervisor_ID);

        }
    }
}



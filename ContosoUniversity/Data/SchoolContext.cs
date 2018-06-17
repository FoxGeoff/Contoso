using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //student
            modelBuilder.Entity<Student>()
               .Property(t => t.CreatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP()");

            modelBuilder.Entity<Student>()
               .Property(t => t.UpdatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP()");
            //customer
            modelBuilder.Entity<Customer>()
               .Property(t => t.CreatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP()");

            modelBuilder.Entity<Customer>()
               .Property(t => t.UpdatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP()");

            modelBuilder.Entity<Customer>()
               .Property(t => t.AssociatedEmployeeId)
               .HasDefaultValueSql(null);

            modelBuilder.Entity<Customer>()
                .Property(t => t.AssociatedLocation)
                .HasDefaultValueSql("1");

            modelBuilder.Entity<Customer>()
                .Property(t => t.AssociatedCustomerId)
                .HasDefaultValueSql(null);

            modelBuilder.Entity<Customer>()
                .Property(t => t.BillAddressDifferent)
                .HasDefaultValueSql("0");

            modelBuilder.Entity<Customer>()
                .Property(t => t.IsNotExportedContact)
                .HasDefaultValueSql("0");

            ////modelBuilder.Entity<Customer>()
            ////   .Property(t => t.IsRegisteredToC4)
            ////   .HasDefaultValueSql("0");

            modelBuilder.Entity<Customer>()
               .Property(t => t.DateAdded)
               .HasDefaultValueSql(null);
        }
    }
}
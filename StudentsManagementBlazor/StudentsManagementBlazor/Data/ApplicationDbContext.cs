using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentsManagementBlazor.Shared.Models;
using StudentsManagementShared.Models;

namespace StudentsManagementBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<SystemCode> SystemCodes { get; set; }
        public DbSet<SystemCodeDetail> SystemCodeDetails { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookIssuance> BookIssuanceHistory { get; set; }
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<HostelRoom> HostelRooms { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<ComplaintNote> ComplaintNotes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(builder);

            builder.Entity<Student>()
             .HasOne(f => f.Country)
             .WithMany()
             .HasForeignKey(f => f.CountryId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

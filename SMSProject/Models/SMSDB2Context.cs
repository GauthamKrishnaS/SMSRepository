using Microsoft.EntityFrameworkCore;

namespace SMSProject.Models {
    public class SMSDB2Context : DbContext {

        public SMSDB2Context(DbContextOptions<SMSDB2Context> options): base (options)
        { 
        }
        public DbSet<Admin> Admins { get; set; }    
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get;set; }
      
    }
}

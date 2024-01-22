using LinhChiDoiSOS.Domain.Entities;
using LinhChiDoiSOS.Domain.IdentityModels;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Common.Interfaces
{
    public interface ILinhChiDoiSOSDbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<BookingDetail> BookingDetail { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ComboCourse> ComboCourse { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseDetail> CourseDetail { get; set; }
        public DbSet<Emergency> Emergency { get; set; }
        public DbSet<EmergencyCategory> EmergencyCategory { get; set; }
        public DbSet<EmergencyDetail> EmergencyDetail { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

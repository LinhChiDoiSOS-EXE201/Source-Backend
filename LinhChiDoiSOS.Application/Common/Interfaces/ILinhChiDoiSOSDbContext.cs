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
        public DbSet<ComboService> ComboService { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceDetail> ServiceDetail { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

using Duende.IdentityServer.EntityFramework.Options;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Domain.Entities;
using LinhChiDoiSOS.Domain.IdentityModels;
using LinhChiDoiSOS.Infrastructure.Persistence.Interceptors;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Reflection;

namespace LinhChiDoiSOS.Infrastructure.Persistence
{
    public class LinhChiDoiSOSDbContext : ApiAuthorizationDbContext<ApplicationUser>, ILinhChiDoiSOSDbContext
    {
        private readonly IMediator _mediator;
        private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

        public LinhChiDoiSOSDbContext(
            DbContextOptions<LinhChiDoiSOSDbContext> options, 
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            IMediator mediator,
            AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor) 
            : base(options, operationalStoreOptions)
        {
            _mediator = mediator;
            _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set ; }
        public DbSet<TodoItem> TodoItems { get ; set; }
        public DbSet<TodoList> TodoLists { get ; set ; }
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<AppIdentityRole>()
                .HasData(
                    new AppIdentityRole
                    {
                        Id = "37dde3f4-d0c9-4477-97d6-ff29f677dccc",
                        Name = "Manager",
                        NormalizedName = "MANAGER",
                        ConcurrencyStamp = null,
                        Description = "Quản lí hệ thống"
                    },
                    new AppIdentityRole
                    {
                        Id = "b9cf3487-3d04-4cbf-85b7-e33360566485",
                        Name = "Customer",
                        NormalizedName = "CUSTOMER",
                        ConcurrencyStamp = null,
                        Description = "Khách hàng"
                    }
                );
            builder.Entity<ApplicationUser>()
                .HasData(
                    new ApplicationUser
                    {
                        Id = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                        Fullname = "Nguyễn Thành Nhân",
                        BirthDay = DateTime.Parse("2002-06-20 08:30:56"),
                        Image = null,
                        UserName = "NhanNguyen",
                        NormalizedUserName = "NHANNGUYEN",
                        Email = "nhan@gmail.com",
                        NormalizedEmail = "NHAN@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                        SecurityStamp = "FHSBRSP7Q6SW6JWBVKCFBC6LKFR4MAR7",
                        ConcurrencyStamp = "445607b7-57f3-4092-9129-c8becc104929",
                        PhoneNumber = "0961868641",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    }
                );
            builder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>
                    {
                        UserId = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                        RoleId = "37dde3f4-d0c9-4477-97d6-ff29f677dccc"
                    }
                );

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEvents(this);

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

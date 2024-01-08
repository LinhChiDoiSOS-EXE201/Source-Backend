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
        public DbSet<ComboService> ComboService { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceDetail> ServiceDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
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

using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Domain.IdentityModels;
using LinhChiDoiSOS.Infrastructure.Files;
using LinhChiDoiSOS.Infrastructure.Identity;
using LinhChiDoiSOS.Infrastructure.Persistence;
using LinhChiDoiSOS.Infrastructure.Persistence.Interceptors;
using LinhChiDoiSOS.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace LinhChiDoiSOS.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<AuditableEntitySaveChangesInterceptor>();

            if (configuration.GetValue<bool>("UseInMemoryDatabase")) {
                services.AddDbContext<LinhChiDoiSOSDbContext>(options =>
                                   options.UseInMemoryDatabase("LinhChiDoiSOSDb123"));
            }
            else {
                services.AddDbContext<LinhChiDoiSOSDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                        builder => builder.MigrationsAssembly(typeof(LinhChiDoiSOSDbContext).Assembly.FullName)));
            }

            services.AddScoped<ILinhChiDoiSOSDbContext>(provider => provider.GetRequiredService<LinhChiDoiSOSDbContext>());
            services.AddScoped<LinhChiDoiSOSDbContextInitialiser>();

            services
            .AddDefaultIdentity<ApplicationUser>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<LinhChiDoiSOSDbContext>();

            services.AddIdentityServer()
            .AddApiAuthorization<ApplicationUser, LinhChiDoiSOSDbContext>();

            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IIdentityService, IdentityService>();
            services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();

            services.AddAuthentication(o =>
            {
                o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                o.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
               {
                   options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                   options.SlidingExpiration = true;
                   options.AccessDeniedPath = "/Forbidden/";
                   options.LoginPath = "/Login";
                   options.LogoutPath = "/Logout";
                   options.ReturnUrlParameter = "redirectUrl";
                   options.Cookie.IsEssential = true;
                   options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                   options.Cookie.SameSite = SameSiteMode.Lax;
               });

            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                    //.AddAuthenticationSchemes(
                    //    CookieAuthenticationDefaults.AuthenticationScheme‌​,
                    //    GoogleDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .Build();

                options.AddPolicy("Manager", policy => policy
                    .Combine(options.DefaultPolicy)
                    .RequireRole("Manager")
                    .Build());
                options.AddPolicy("Staff", policy => policy
                    .Combine(options.DefaultPolicy)
                    .RequireRole("Staff")
                    .Build());
                options.AddPolicy("Employee", policy => policy
                   .Combine(options.DefaultPolicy)
                   .RequireRole("Employee")
                   .Build());
                options.AddPolicy("ManagerOrStaff", policy => policy
            .Combine(options.DefaultPolicy)
            .RequireRole("Manager", "Employee")
            .Build());
            });

            services.AddSwaggerGen(options =>
            {
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    BearerFormat = "JWT",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Type = SecuritySchemeType.ApiKey,
                    Description = "Put \"Bearer {token}\" your JWT Bearer token on textbox below!",
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = JwtBearerDefaults.AuthenticationScheme
                    },
                };
                options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, jwtSecurityScheme);
                options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        jwtSecurityScheme,
                        new List<string>()
                    }
                });
            });

            services.AddSession();

            return services;
        }
    }
}

using LinhChiDoiSOS.Application;
using LinhChiDoiSOS.Infrastructure;
using LinhChiDoiSOS.Infrastructure.Persistence;
using LinhChiDoiSOS.WebAPI;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddWebUIServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment()) {
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();

    // Initialise and seed database
    using (var scope = app.Services.CreateScope()) {
        var initialiser = scope.ServiceProvider.GetRequiredService<LinhChiDoiSOSDbContextInitialiser>();
        await initialiser.InitialiseAsync();
        await initialiser.SeedAsync();
    }
}
else {
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}*/
app.UseMigrationsEndPoint();

app.UseHealthChecks("/health");
app.UseHttpsRedirection();
app.UseStaticFiles();

/*app.UseSwaggerUi3(settings =>
{
    settings.Path = "/api";
    settings.DocumentPath = "/api/specification.json";
});*/
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

app.UseAuthentication();
app.UseIdentityServer();
app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapRazorPages();

app.MapFallbackToFile("index.html");

app.Run();

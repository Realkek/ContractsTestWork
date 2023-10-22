using ContractsTestWork.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureRepositories();
builder.Services.ConfigureDomainServices();
builder.Services.AddControllersWithViews();

var app = builder.Build();
// Add services to the container.
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ContractsPages}/{action=Import}");

app.Run();
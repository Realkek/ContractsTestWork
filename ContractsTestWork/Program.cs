using ContractsTestWork.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureDbContext(builder.Configuration);
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
// Add services to the container.
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ContractsPagesController}/{action=Index}");

app.Run();
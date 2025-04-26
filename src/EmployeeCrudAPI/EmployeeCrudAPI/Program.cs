using EmployeeCrudAPI.Data;
using EmployeeCrudAPI.Mapping;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EmployeeDbDataContext>(options =>
options.UseSqlServer(connectionString:
builder.Configuration.GetConnectionString("EmployeeDbConnectionString")));
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

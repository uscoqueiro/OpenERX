using OpenERX.Core.Customers;
using OpenERX.Repositories.Customers;
using OpenERX.Repositories.Shared.Sql;
using OpenERX.Services.Customers;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 

builder.Services.AddTransient<SqlConnectionProvider>(_ => new SqlConnectionProvider("server=.;database=DB_OPEN_ERX;user=open_erx;password=d78ca73e-a260-42df-a659-c42b48e30520"));
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<ICustomerService, CustomerService>();
 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
   
}

app.UseAuthorization();

app.MapControllers();

app.Run();

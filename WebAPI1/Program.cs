using Microsoft.EntityFrameworkCore;
using WebAPI1.Data;
using WebAPI1.Repositories.Abstract;
using WebAPI1.Repositories.Concrete;
using WebAPI1.Services.Abstract;
using WebAPI1.Services.Concrete;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("myconn");
builder.Services.AddDbContext<ECommerceDbContext>(opt =>
{
    opt.UseSqlServer(connection);
});

// Registrate Customer

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();


// Registrate Product

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();


// Registrate Order

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

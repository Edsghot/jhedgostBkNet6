using jhedgostBK.Configuration.DataBase;
using jhedgostBK.Modules.CustomerTestimonials.Application.Adapter;
using jhedgostBK.Modules.CustomerTestimonials.Application.Ports;
using jhedgostBK.Modules.CustomerTestimonials.Domain.IRepository;
using jhedgostBK.Modules.CustomerTestimonials.Infraestructure.Presenter;
using jhedgostBK.Modules.CustomerTestimonials.Infraestructure.Repository;
using jhedgostBK.Modules.EmployeeTestimonials.Application.Adapter;
using jhedgostBK.Modules.EmployeeTestimonials.Application.Port;
using jhedgostBK.Modules.EmployeeTestimonials.Domain.IRepository;
using jhedgostBK.Modules.EmployeeTestimonials.Infraestructure.Presenter;
using jhedgostBK.Modules.EmployeeTestimonials.Infraestructure.Repository;
using jhedgostBK.Modules.Services.Application.Adapter;
using jhedgostBK.Modules.services.Application.Port;
using jhedgostBK.Modules.services.Domain.IRepository;
using jhedgostBK.Modules.Services.Infraestructure.Presenter;
using jhedgostBK.Modules.Services.Infraestructure.Repository;
using jhedgostBK.Modules.User.Application.Adapter;
using jhedgostBK.Modules.User.Application.Port;
using jhedgostBK.Modules.User.Domain.IRepository;
using jhedgostBK.Modules.User.Infraestructure.Presenter;
using jhedgostBK.Modules.User.Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MySqlContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MySQLConnection"),
    new MySqlServerVersion(new Version(8, 0, 21))));
builder.Services.AddScoped<IUserInputPort, UserAdapter>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserOutPort, UserPresenter>();

builder.Services.AddScoped<ICustomerTInputPort, CustomerTestimonialsAdapter>();
builder.Services.AddScoped<ICustomerTRepository, CustomerTRepository>();
builder.Services.AddScoped<ICustomerTOutPort, CustomerTPresenter>();

builder.Services.AddScoped<IEmployeeTInputPort, EmployeeTAdapter>();
builder.Services.AddScoped<IEmployeeTRepository, EmployeeTRepository>();
builder.Services.AddScoped<IEmployeeTOutPort, EmployeeTPresenter>();

builder.Services.AddScoped<IServiceInputPort, ServicesAdapter>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IServiceOutPort, ServicePresenter>();


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

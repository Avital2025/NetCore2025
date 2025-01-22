using Queue_management_system.Core.IRepository;
using Queue_management_system.Core.Iservice;
using Queue_management_system.Data.Repository;
using Queue_management_system.Service.Entities;
using Queue_management_system.service;
using Queue_management_system;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddScoped<IEmployeesService, EmployeesService>();
        builder.Services.AddScoped<IGenericRepository<EmployeesEntity>, EmployeesRepository>();


        builder.Services.AddScoped<IPatientsService, PatientsService>();
        builder.Services.AddScoped<IGenericRepository<PatientsEntity>, PatientsRepository>();

        builder.Services.AddScoped<IQueuesService, QueuesService>();
        builder.Services.AddScoped<IGenericRepository<QueuesEntity>, QueuesRepository>();

        builder.Services.AddScoped<IRoomsService, RoomsService>();
        builder.Services.AddScoped<IGenericRepository<RoomsEntity>, RoomsRepository>();




        builder.Services.AddDbContext<DataContext>(option =>
        {

            option.UseSqlServer("Data Source=DESKTOP-SSNMLFD;Initial Catalog=system;Integrated Security=true; ");
        });

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

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
    }
}
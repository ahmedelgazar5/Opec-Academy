
using Microsoft.EntityFrameworkCore;
using OPEC_Academy_API.Models;
using OpecAcademyManager.BLL.Repository;
using OpecDataBase.DAL;
using System.Security.Principal;

namespace OPEC_Academy_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Register Repositories 
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();

            // Register OpecAcademy
            builder.Services.AddDbContext<OpecAcademyContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("CS"))
            );


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
        }
    }
}
using LibreHub.Services;
using LIbreHubBackend.Domain;
using LIbreHubBackend.Interfaces;
using Npgsql;
using System.Data.Common;

namespace LIbreHubBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Регистрация подключения как Scoped
            builder.Services.AddScoped<NpgsqlConnection>(provider =>
            {
                var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
                return new NpgsqlConnection(connectionString);
            });

            // Scoped для репозитория и сервиса
            builder.Services.AddScoped<BookRepository>();
            builder.Services.AddScoped<IBookService, BookService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
}

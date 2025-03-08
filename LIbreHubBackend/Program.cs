using LIbreHubBackend.Domain;
using LIbreHubBackend.Interfaces;
using LIbreHubBackend.Services;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace LIbreHubBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Singltone - живёт весь цилк приложения, это деду надо
            builder.Services.AddSingleton<NpgsqlConnection>(provider =>
            {
                var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
                return new NpgsqlConnection(connectionString);
            });

            builder.Services.AddSingleton<BookRepository>();
            builder.Services.AddSingleton<UserRepository>();
            builder.Services.AddSingleton<IBookService, BookService>();
            builder.Services.AddSingleton<IUserService, UserService>();
            // При регистрации другого репозитория у него может быть свой коннекшн, либо нужно разобраться
            // чтобы наш 1 коннекш закрывался и открывался в нужные моменты
            // Чтобы исключить конфликты
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

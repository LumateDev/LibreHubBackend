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
            // Singltone - æèâ¸ò âåñü öèëê ïðèëîæåíèÿ, ýòî äåäó íàäî
            builder.Services.AddSingleton<NpgsqlConnection>(provider =>
            {
                var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
                return new NpgsqlConnection(connectionString);
            });

            builder.Services.AddSingleton<BookRepository>();
            builder.Services.AddSingleton<UserRepository>();
            builder.Services.AddSingleton<GroupRepository>();
            builder.Services.AddSingleton<IBookService, BookService>();
            builder.Services.AddSingleton<IUserService, UserService>();
            builder.Services.AddSingleton<IGroupService, GroupService>();
            // Ïðè ðåãèñòðàöèè äðóãîãî ðåïîçèòîðèÿ ó íåãî ìîæåò áûòü ñâîé êîííåêøí, ëèáî íóæíî ðàçîáðàòüñÿ
            // ÷òîáû íàø 1 êîííåêø çàêðûâàëñÿ è îòêðûâàëñÿ â íóæíûå ìîìåíòû
            // ×òîáû èñêëþ÷èòü êîíôëèêòû
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

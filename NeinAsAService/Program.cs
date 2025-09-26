using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using NeinAsAService.Models;

namespace NeinAsAService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var keepAliveConnection = new SqliteConnection("DataSource=No.Db");
            keepAliveConnection.Open();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(keepAliveConnection));

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.EnsureCreated();

            }

            app.Run();
        }
    }
}

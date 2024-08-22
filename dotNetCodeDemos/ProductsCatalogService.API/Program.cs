
using Microsoft.EntityFrameworkCore;
using ProductsCatalogService.API.Model.Data;

namespace ProductsCatalogService.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            string conStr = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<ProductsDbContext>(options => {
                options.UseSqlServer(conStr);
            });



            builder.Services.AddControllers().AddXmlSerializerFormatters();
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

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

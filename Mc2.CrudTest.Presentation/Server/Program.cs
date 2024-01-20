using Microsoft.OpenApi.Models;
using BussinessLogic;
using Infrastructure;
using Infrastructure.DbCore;
using Microsoft.EntityFrameworkCore;



namespace Mc2.CrudTest.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

          
            builder.Services.AddControllers();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddMemoryCache();
            builder.Services.AddBussinessLogicServices();
            builder.Services.AddInfrastructureServices();


            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "mason-chase v1",
                    Title = "mason-chase",
                    Description = "mason-chase"
                });
              
            });
            builder.Services.AddDbContextPool<Context>(
     options => options.UseSqlServer(
         "Data Source=.;Initial Catalog=mason-chase;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False"
         )
     );

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllers();
            app.Run();
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace WebApiMuseo
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuracion)
        {
            Configuration = configuracion;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();            
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("defaultConnection"))
            );

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c => 
                c.SwaggerDoc(
                    "v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo { 
                        Title = "ApiMuseo",
                        Version = "v1"
                    }
            ));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

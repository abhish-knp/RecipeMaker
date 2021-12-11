//using BookStore.Data.Interfaces;
//using BookStore.Data.Models;
//using BookStore.Data.Repositories;
//using Microsoft.EntityFrameworkCore;

namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();



        }
        /*
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IBookRepository, BookDatabase>();

            services.AddControllers();

            var connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\patri\Documents\BookStore.mdf;Initial Catalog=Bookstore;Integrated Security=True;Connect Timeout=30";
            //var connection = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<BookStoreContext>
                (options => options.UseSqlServer(connection));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BookStoreAPI", Version = "v1" });
            });
        }
        */

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ContosoRecipe v1"));
            }


            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();




        }
    }
}

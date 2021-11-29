namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //services.AddSwaggerGen(c =>



        }

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

            /*
             * app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello From ASP.NET Core Web API");
                });

                endpoints.MapGet("/Resource1", async context =>
                {
                    await context.Response.WriteAsync("Hello From ASP.NET Core Web API Resource1");
                });
            });
             */



        }
    }
}

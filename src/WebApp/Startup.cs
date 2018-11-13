using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace WebApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app) =>
            app.Run(async context =>
            {
                await context.Response.WriteAsync($"{System.DateTime.UtcNow} - Hello from Docker!");
            });
    }
}

using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;


namespace BlogPostsUsers.Application.Services
{
    public static class DataManagementService
    {
        public static void MigrationInitialisation(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var serviceDb = serviceScope.ServiceProvider.GetService<ContextDb>();
                serviceDb.Database.Migrate();
            }
        }

        public static async void SincronizaInitialisation(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var popular = serviceScope.ServiceProvider.GetRequiredService<ISincronizaService>();

                await popular.SincronizarDados();
            }
        }
    }
}

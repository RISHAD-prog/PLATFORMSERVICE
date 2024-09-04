using PLATFORMSERVICE.Model;

namespace PLATFORMSERVICE.Data
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext appDbContext)
        {
            if (!appDbContext.platforms.Any())
            {
                Console.WriteLine("Seeding....");
                appDbContext.platforms.AddRange(
                        new PlatForm { Name="Dot Net" , Publisher="Microsoft", Cost= "Free"},
                        new PlatForm { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" }
                    );

                appDbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("We already have data");
            }
        }
    }
}

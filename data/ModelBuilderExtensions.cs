using Tool_Website.Models;
using Microsoft.EntityFrameworkCore;
namespace Tool_Website.data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder){
            modelBuilder.Entity<product>().HasData(
                new product
                {
                    Id = 1,
                    Name = "Flat Screwdriver",
                    Description = "A flat screwdriver, useful for any situation!",
                    Price = 6.99m,
                    ImageName = "flat.jpg"
                },
                new product
                {
                    Id = 2,
                    Name = "Diamond Screwdriver",
                    Description = "A diamond screwdriver, for those difficult screws!",
                    Price = 6.99m,
                    ImageName = "star.jpg"
                },
                new product
                {
                    Id = 3,
                    Name = "Hammer",
                    Description = "A hammer, for hitting those screws in place!",
                    Price = 9.99m,
                    ImageName = "hammer.png"
                },
                new product
                {
                    Id = 4,
                    Name = "Pliers",
                    Description = "Pliers, useful for stripping wires!",
                    Price = 6.99m,
                    ImageName = "pliers.jpg"
                },
                new product
                {
                    Id = 5,
                    Name = "Shovel",
                    Description = "A shovel, trying to dig a hole? This is perfect for you!",
                    Price = 14.99m,
                    ImageName = "shovel.jpg"
                },
                new product
                {
                    Id = 6,
                    Name = "Wrench",
                    Description = "A wrench, for tighting and lossing those boltss!",
                    Price = 7.99m,
                    ImageName = "wrench.jpg"
                }
            );
            return modelBuilder;
        }

    }
}
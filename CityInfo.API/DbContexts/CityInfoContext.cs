using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts;

public class CityInfoContext : DbContext
{
    public DbSet<City> Cities { get; set; } = null!;
    public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

    public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>().HasData(
            new City("Rio de Janeiro")
            {
                Id = 1,
                Description = "Wonderful city",
            },
            new City("São Paulo")
            {
                Id = 2,
                Description = "City of Stone",
            },
            new City("Brasília")
            {
                Id = 3,
                Description = "Capital of Brazil",
            }
        );

        modelBuilder.Entity<PointOfInterest>().HasData(
            new PointOfInterest("Sugarloaf")
            {
                Id = 1,
                CityId = 1,
                Description = "Rock peak of Sugarloaf, towering 394 meters above the harbor. It sits on a point of land that projects out into the bay and wraps around its harbor, and is connected to the city by a low strip of land."
            },
            new PointOfInterest("Christ the Redeemer")
            {
                Id = 2,
                CityId = 1,
                Description = "The giant statue of Christ overlooking the city from the 709-meter summit of Corcovado is almost as widely recognized a symbol of Rio as the distinctive shape of Sugarloaf."
            },
            new PointOfInterest("Liberdade")
            {
                Id = 3,
                CityId = 2,
                Description = "Neighborhood with many oriental influences. Home of Japanese immigrants"
            },
            new PointOfInterest("MASP")
            {
                Id = 4,
                CityId = 2,
                Description = "The São Paulo Museum of Art, known locally as MASP, only opened in 1968 but has the most representative and comprehensive collection of western art in Latin America."
            },
            new PointOfInterest("Praça dos Três Poderes")
            {
                Id = 5,
                CityId = 3,
                Description = "Brasilia's governmental center combines some of its most striking landmark buildings and monuments into a stunning showcase of modern architecture."
            },
            new PointOfInterest("Palácio do Itamaraty")
            {
                Id = 6,
                CityId = 3,
                Description = "he Palácio dos Arcos, also known as the Palácio Itamaraty, houses the Foreign Ministry and is one of Oscar Niemeyer's greatest achievements."
            }

        );
        
        base.OnModelCreating(modelBuilder);
    }
}
using Locatic.Entities;

namespace Locatic.Data;

public static class DbSeeder
{
    public static void Seed(AppDbContext context)
    {
        if (context.Brands.Any())
        {
            return;
        }

        var renault = new Brand { Name = "Renault", Country = "France" };
        var peugeot = new Brand { Name = "Peugeot", Country = "France" };
        var bmw = new Brand { Name = "BMW", Country = "Allemagne" };

        context.Brands.AddRange(renault, peugeot, bmw);
        context.SaveChanges();

        var clio = new Modele { Name = "Clio", BrandId = renault.Id };
        var peugeot208 = new Modele { Name = "208", BrandId = peugeot.Id };
        var serie3 = new Modele { Name = "Série 3", BrandId = bmw.Id };

        context.Modeles.AddRange(clio, peugeot208, serie3);
        context.SaveChanges();

        context.Cars.AddRange(
            new Car
            {
                RegistrationNumber = "AA-123-BB",
                Year = 2022,
                NumberOfPlaces = 5,
                PricePerDay = 45,
                FuelType = "Essence",
                ModeleId = clio.Id
            },
            new Car
            {
                RegistrationNumber = "CC-456-DD",
                Year = 2023,
                NumberOfPlaces = 5,
                PricePerDay = 50,
                FuelType = "Diesel",
                ModeleId = peugeot208.Id
            },
            new Car
            {
                RegistrationNumber = "EE-789-FF",
                Year = 2021,
                NumberOfPlaces = 5,
                PricePerDay = 90,
                FuelType = "Essence",
                ModeleId = serie3.Id
            }
        );

        context.Clients.AddRange(
            new Client
            {
                LastName = "Dupont",
                FirstName = "Jean",
                Email = "jean.dupont@example.com",
                PhoneNumber = "0600000001"
            },
            new Client
            {
                LastName = "Martin",
                FirstName = "Claire",
                Email = "claire.martin@example.com",
                PhoneNumber = "0600000002"
            }
        );

        context.SaveChanges();
    }
}
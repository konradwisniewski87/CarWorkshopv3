using CarWorkshop.Infrastructure.Persistance;


namespace CarWorkshop.Infrastructure.Seeders;

public class CarWorkshopSeeder
{
    private readonly CarWorkshopDbContext _dbContext;

    public CarWorkshopSeeder(CarWorkshopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Seed()
    {
        if (await _dbContext.Database.CanConnectAsync())
        {
            if (!_dbContext.CarWorkshops.Any())
            {
                var renault = new Domain.Entities.CarWorkshop()
                {
                    Name = "Renault",
                    Description = "Renault Garage",
                    ContactDetails = new()
                    {
                        City = "Radom",
                        Street = "Kielecka",
                        PostalCode = "26-600",
                        PhoneNumer = "+4812345678",
                    },
                };

                renault.EncodeName();

                _dbContext.Add(renault);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}

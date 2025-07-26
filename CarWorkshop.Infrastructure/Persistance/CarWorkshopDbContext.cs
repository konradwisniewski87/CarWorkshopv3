namespace CarWorkshop.Infrastructure.Persistance;

public class CarWorkshopDbContext : DbContext
{
    public DbSet<Domain.Entities.CarWorkshop> CarWorkshops { get; set; }

    public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options) : base(options)
    {
        
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Server=(localDB)\\mssqllocaldb;DataBase=CarworkshopDbV3;Trusted_Connection=True;");
    //}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.CarWorkshop>()
            .OwnsOne(c=>c.ContactDetails);
    }
}

using CompleteProject.Entities;
using Microsoft.EntityFrameworkCore;

public class DataRepo : DbContext
{
    public DbSet<Member> Members { get; set; }
    public DbSet<Library> Libraries { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Buyer> Buyers { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Bill> Bills { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CPDB2;Data Source=DESKTOP-9373OG3\SQL2019");
    }

}


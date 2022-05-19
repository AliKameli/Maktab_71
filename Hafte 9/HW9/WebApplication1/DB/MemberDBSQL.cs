using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApplication1.Models;

namespace WebApplication1.DB
{
    public class MemberDBSQL : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WebApp1DB;Data Source=DESKTOP-9373OG3\SQL2019");
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
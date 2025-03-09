using Microsoft.EntityFrameworkCore;
using ModelLayer.Entity;

namespace ModelLayer.Context
{
    public class AddressBookContext : DbContext
    {
        public AddressBookContext(DbContextOptions<AddressBookContext> options) : base(options)
        {
        }
        public DbSet<AddressBookEntity> Contacts { get; set; }
    }
}
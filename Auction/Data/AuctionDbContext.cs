using AuctionManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionManagement.Data
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Auction> Auctions { get; set; }

    }
}

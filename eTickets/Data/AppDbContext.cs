using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}

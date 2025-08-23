using System.Net;
using Microsoft.EntityFrameworkCore;

namespace SchoolApp.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
    }
}

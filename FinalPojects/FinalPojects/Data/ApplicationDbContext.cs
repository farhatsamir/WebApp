using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinalPojects.Models;

namespace FinalPojects.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<FinalPojects.Models.Medicine> Medicine { get; set; } = default!;
    }
}

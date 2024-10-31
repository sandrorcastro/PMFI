
using Domain.Entities.DBProsiga;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ITBI.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    public virtual DbSet<Contribuinte> Contribuintes { get; set; } = null!;
    }
}

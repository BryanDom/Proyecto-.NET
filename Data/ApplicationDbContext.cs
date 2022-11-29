using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestauranteMexicano.Models;

namespace RestauranteMexicano.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Platillo> Platillos { get; set; }
}

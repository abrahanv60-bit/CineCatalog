using Microsoft.EntityFrameworkCore;

namespace CineCatalog.API.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    // Cada equipo agregará sus DbSet cuando integremos los modelos.
}

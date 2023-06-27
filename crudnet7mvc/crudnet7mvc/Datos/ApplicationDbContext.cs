using crudnet7mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace crudnet7mvc.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Agregar los modelos aqui
        public DbSet<Contacto> Contacto { get; set; }
    }
}

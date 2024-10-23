using Microsoft.EntityFrameworkCore;

namespace concurso_p2024.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<concurso_p2024.Models.Materia> Materia { get; set; }
        public DbSet<concurso_p2024.Models.Estudiante> Estudiante { get; set; }
        public DbSet<concurso_p2024.Models.Profesor> Profesor { get; set; }
    }
}

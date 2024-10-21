using Microsoft.EntityFrameworkCore;


namespace RecodeProject.Models
{
    public class CursoDbContext : DbContext
    {
        public CursoDbContext(DbContextOptions<CursoDbContext> options): base(options) { }
        public DbSet<Curso> Curso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>().HasData(
                new Curso { ID = 1, Description = "Asp Net MVC", Workload = 40 },
                new Curso { ID = 2, Description = "Banco de Dados", Workload = 30 },
                new Curso { ID = 3, Description = "React", Workload = 60 },
                new Curso { ID = 4, Description = "HTML e CSS", Workload = 20 },
                new Curso { ID = 5, Description = "C#", Workload = 50 },
                new Curso { ID = 6, Description = "Python", Workload = 45 }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using RolCursos.Models;

namespace RolCursos.Repository
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Curso> TabelaDeCursos { get; set; }
        public DbSet<Professor> TabelaDeProfessores { get; set; }



        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Professor>().HasOne(professor => professor.Curso).WithOne(curso => curso.Professor)
        //        .HasForeignKey<Curso>(curso => curso.ProfessorId);

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder construtor)
        {
            string conexao = "Server=localhost\\SQLEXPRESS;Database=RolCursos;Integrated Security=SSPI";
            construtor.UseSqlServer(conexao);
        }


    }


    
}

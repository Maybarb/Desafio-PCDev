using Microsoft.EntityFrameworkCore;
using RolCursos.Models;

namespace RolCursos.Repository
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Curso> TabelaDeCursos { get; set; }
        public DbSet<Professor> TabelaDeProfessores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder construtor)
        {
            string conexao = "Server=localhost\\SQLEXPRESS;Database=RolCursos;Integrated Security=SSPI";
            construtor.UseSqlServer(conexao);
        }


    }


    
}

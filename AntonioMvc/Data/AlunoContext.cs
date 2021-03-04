using Microsoft.EntityFrameworkCore;
using AntonioMvc.Models;

namespace AntonioMvc.Data
{
    public class AlunoContext : DbContext
    {
        public AlunoContext (DbContextOptions<AlunoContext> options) : base(options){}

        public DbSet<Aluno> Aluno { get; set; }
    }
}
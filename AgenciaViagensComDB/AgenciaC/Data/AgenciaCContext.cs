using AgenciaC.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciaC.Data
{
    public class AgenciaCContext : DbContext
    {
        public AgenciaCContext(DbContextOptions<AgenciaCContext> options): base(options)
            {
            }
        public DbSet<Passageiro> Passsageiros { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
    }
}


using financas.domain;
using Microsoft.EntityFrameworkCore;

namespace financas.repository
{
    public class FinancasContext : DbContext
    {
        public FinancasContext(DbContextOptions<FinancasContext>options)
            :base(options){}
        
        public DbSet<Despesa> Despesas {get; set;}

        public DbSet<GrupoDespesa> GrupoDespesas {get; set;}
    }
}
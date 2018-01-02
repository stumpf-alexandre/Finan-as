using Microsoft.EntityFrameworkCore;

namespace financas.WebApi.Models
{
    public class FinancasContext : DbContext
    {
        public FinancasContext(DbContextOptions<FinancasContext> options)
            :base(options){}

        public DbSet<Despesa> Despesas {get; set;}

        public DbSet<GrupoDespesa> GrupoDespesas {get; set;}
    }
}
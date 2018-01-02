using System.Collections.Generic;
using System.Linq;

namespace financas.WebApi.Models
{
    public class GrupoDespesaRepository : IGrupoDespesaRepository
    {
        private FinancasContext context;
        public GrupoDespesaRepository(FinancasContext context)
        {           
            this.context = context;
        }
        public void Create(GrupoDespesa grupoDespesa)
        {
            context.GrupoDespesas.Add(grupoDespesa);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.GrupoDespesas.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<GrupoDespesa> GetAll()
        {
            return context.GrupoDespesas.ToList();
        }

        public GrupoDespesa GetById(int id)
        {
            return context.GrupoDespesas.SingleOrDefault(x=>x.Id == id);
        }

        public void Update(GrupoDespesa grupoDespesa)
        {
            context.Entry(grupoDespesa).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        List<GrupoDespesa> IGrupoDespesaRepository.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace financas.WebApi.Models
{
    public class DespesaRepository : IDespesaRepository
    {
        private FinancasContext context;
        public DespesaRepository(FinancasContext context)
        {           
            this.context = context;
        }
        public void Create(Despesa despesa)
        {
            context.Despesas.Add(despesa);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Despesas.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Despesa> GetAll()
        {
            return context.Despesas.ToList();
        }

        public Despesa GetById(int id)
        {
            return context.Despesas.SingleOrDefault(x=>x.id == id);
        }

        public void Update(Despesa despesa)
        {
            context.Entry(despesa).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
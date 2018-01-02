using System.Collections.Generic;
using System.Linq;
using financas.domain;
using Microsoft.EntityFrameworkCore;

namespace financas.repository
{
    public class DespesaRepository : IDespesaRepository
    {
        private FinancasContext context;

        public DespesaRepository(FinancasContext context){
            this.context = context;
        }

        public void Create(Despesa despesa){
            despesa.grupoDespesas = context.GrupoDespesas.Find(despesa.grupoDespesas.Id);
            context.Despesas.Add(despesa);
            context.SaveChanges();
        }

        public void Delete(int id){
            context.Despesas.Remove(context.Despesas.Find(id));
            context.SaveChanges();
        }

        public void Update(Despesa despesa){
            context.Entry(despesa).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Despesa GetById(int id){
            return context.Despesas.Include(x=>x.grupoDespesas).SingleOrDefault(x=>x.GrupoDespesaId == id);
        }

        public List<Despesa> GetAll(){
            return context.Despesas.Include(x=>x.grupoDespesas).ToList();
        }
    }
}

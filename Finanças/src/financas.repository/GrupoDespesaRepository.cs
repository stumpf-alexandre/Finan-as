using System.Collections.Generic;
using System.Linq;
using financas.domain;

namespace financas.repository
{
    public class GrupoDespesaRepository : IGrupoDespesaRepository
    {
        private readonly FinancasContext context;
        public GrupoDespesaRepository(FinancasContext context){
            this.context = context;
        }

        public List<GrupoDespesa> GetAll(){
            return context.GrupoDespesas.ToList();
        }

        public GrupoDespesa GetById(int id){
            return context.GrupoDespesas.Find(id);
        }
    }
}
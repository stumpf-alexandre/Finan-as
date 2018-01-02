using System.Collections.Generic;
using financas.domain;

namespace financas.repository
{
    public interface IGrupoDespesaRepository
    {
         List<GrupoDespesa> GetAll();
         GrupoDespesa GetById(int id);
    }
}
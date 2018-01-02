using System.Collections.Generic;
using financas.domain;

namespace financas.repository
{
    public interface IDespesaRepository
    {
        void Create(Despesa despesa);
        void Update(Despesa despesa);
        void Delete(int id);
        List<Despesa> GetAll();
        Despesa GetById(int id);
    }
}
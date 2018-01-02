using System.Collections.Generic;

namespace financas.WebApi.Models
{
    public interface IDespesaRepository
    {
         void Create(Despesa despesa);

         void Update(Despesa despesa);

         void Delete(int id);

         List<Despesa>GetAll();

         Despesa GetById(int id);
    }
}
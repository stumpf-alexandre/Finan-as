using System.Collections.Generic;

namespace financas.WebApi.Models
{
    public interface IGrupoDespesaRepository
    {

         void Create(GrupoDespesa grupoDespesa);

         void Update(GrupoDespesa grupoDespesa);

         void Delete(int id);
        List<GrupoDespesa> GetAll();
        GrupoDespesa GetById(int id);
    }
}
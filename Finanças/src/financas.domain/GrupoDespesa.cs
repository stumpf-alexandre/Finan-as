using System.Collections.Generic;

namespace financas.domain
{
    public class GrupoDespesa
    {
        public int Id {get; set;}

        public string nomeGrupo {get; set;}

        public IEnumerable<Despesa> Despesas {get; set;}
    }
}
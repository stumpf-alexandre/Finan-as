using System.Collections.Generic;

namespace financas.WebApi.Models
{
    public class GrupoDespesa
    {
                public int Id {get; set;}

        public string nomeGrupo {get; set;}

        public IEnumerable<Despesa> Despesas {get; set;}

        public bool IsComplete {get; set;}
    }
}
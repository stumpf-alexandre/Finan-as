namespace financas.WebApi.Models
{
    public class Despesa
    {
        public int id {get; set;}

        public string nome {get; set;}

        public long numDoc {get; set;}

        public double valor {get; set;}

        public string data {get; set;}

        public int GrupoDespesaId {get; set;}

        public GrupoDespesa grupoDespesas {get; set;}

        public bool IsComplete {get; set;}
    }
}
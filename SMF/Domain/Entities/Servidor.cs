using System.Collections.Specialized;

namespace Domain.Entities
{
    public class Servidor
    {
        
        public long ServidorId { get; set; }  
        public string? Nome { get; set; }
        public string? Matricula { get; set; }
        public int? UnidadeId { get; set; }
        public Unidade? Unidade { get; set; }    
        
        public int? DivisaoId { get; set; }
        public Divisao? Divisao { get; set; }
        public string? Cargo { get; set; }
        public string? Funcao { get; set; }
        public bool? Ativo { get; set; }

        public ICollection<Processo> Processos { get; set; }
        public ICollection<Processo> ExecutaProcessos { get; set; }
        public ICollection<Servidor_TipoProcesso> PodeExecutar { get; set; }
        //public ICollection<Servidor_TipoProcesso> PodeCriar { get; set; }
    }
}
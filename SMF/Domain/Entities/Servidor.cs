using System.Collections.Specialized;

namespace Domain.Entities
{
    public class Servidor
    {
        
        public long ServidorId { get; set; }  
        public string? Nome { get; set; }
        public string? Matricula { get; set; }
        public int? UnidadeId { get; set; }
        public string? Cargo { get; set; }
        public string? Funcao { get; set; }
        public Unidade? Unidade { get; set; }    
        public bool? Ativo { get; set; }
    }
}
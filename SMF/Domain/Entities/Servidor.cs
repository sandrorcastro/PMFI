namespace Domain.Entities
{
    public class Servidor
    {
        
        public long ServidorId { get; set; }  
        public string? Nome { get; set; }
        public string? Matricula { get; set; }

        public bool? Ativo { get; set; }
    }
}
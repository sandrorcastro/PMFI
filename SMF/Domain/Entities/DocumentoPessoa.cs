namespace Domain.Entities
{
    public class DocumentoPessoa
    {
        public int DocumentoPessoaId { get; set; }
        public long PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
        public int TipoDocumentoId { get; set; }
        public TipoDocumento? TipoDocumento { get; set; } 
        public string? Numero { get; set; }
        


    }
}
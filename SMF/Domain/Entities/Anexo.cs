namespace Domain.Entities
{
    
    public class Anexo
    {
        public long ProcessoId { get; set; }
        public Processo? Processo { get; set; }
        public int FluxoProcessoId { get; set; }
        public FluxoProcesso FluxoProcesso { get; set; }
        public int TipoProcessoId { get; set; }
        public TipoProcesso TipoProcesso { get; set; }
        public string AnexoId { get; set; }

        
        public Etapa? Etapa { get; set; }

        
        public string? ImageBase64String { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? NomeArquivo { get; set; }
        public string? Caminho { get; set; }
        public string? TipoAnexo { get; set; }
    }
}

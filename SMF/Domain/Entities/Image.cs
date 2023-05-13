namespace Domain.Entities
{
    
    public class Image
    {
        
        public string? ImageId { get; set; }
        public string? ImageBase64String { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? ProcessoId { get; set; }
        public Processo? Processo { get; set; }
        public int? TipoProcessoId { get; set; }
        public TipoProcesso? TipoProcesso { get; set; }
        public int? SituacaoProcessoId { get; set; }
        public SituacaoProcesso? SituacaoProcesso { get; set; }

        public long? ImovelId { get; set; }
        public Imovel? Imovel { get; set; } 
        public long? EconomiaId { get; set; }
        //public Economia? Economia { get; set; }
        public int? SituacaoEtapaId { get; set; }
        public SituacaoEtapa? situacaoEtapa { get; set; }    
        public int? TipoEtapaId { get; set; }
        //public TipoFoto? TipoEtapa { get; set; }
        public TipoEtapa? TipoEtapa { get; set; }

        public int? PerspectivaId { get; set; }
        public Perspectiva? Perspectiva { get; set; }
        public string? NomeArquivo { get; set; }
        public string? Caminho { get; set; }
    }
}

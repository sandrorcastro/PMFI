namespace Domain.Entities
{
    public class TextoAutuacao
    {
       // public int TextoAutuacaoId { get; set; }    
        public int? TipoProcessoId { get; set; }
        public TipoProcesso? TipoProcesso { get; set; }
        public int? TipoEtapaId { get; set; } 
        public TipoEtapa? TipoEtapa { get; set; }
        
        public string? Descricao { get; set; }
        public string? TextoPadrao { get; set; }
        
        public string? Lei { get; set; }
        public string? TextoLei { get; set; }   
    }
}

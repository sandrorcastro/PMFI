namespace Domain.Entities
{
    public class TipoEtapa
    {
   
        public int TipoEtapaId { get; set; }
        public string? Descricao { get; set; }
        public int? DiasTramite { get; set; }
        public int? Permanencia { get; set; }
        public string? Lei { get; set; }
        public string? TextoLei { get; set; }   

        public string? Template { get; set; }
        public bool? liberado { get; set; }
    }
}

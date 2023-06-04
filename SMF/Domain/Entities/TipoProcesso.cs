
namespace Domain.Entities
{
    public class TipoProcesso
    {
        public int TipoProcessoId { get; set; }
        public string? Descricao { get; set; }
        public int? DiasTramite { get; set; }    
        public int? Permanencia { get; set; } 
        public bool? liberado { get; set; }
        public ICollection<Etapa>? Etapas { get; set; }
        public ICollection<FluxoProcesso>? FluxoProcessos { get; set; }
        public ICollection<Servidor_TipoProcesso>? ExecutadoPor { get; set; }
    }
}

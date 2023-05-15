namespace MVC.ViewModels
{
    public class TipoProcessoViewModel
    {
        public int TipoProcessoId { get; set; }
        public string? Descricao { get; set; }
        public int? DiasTramite { get; set; }
        public int? Permanencia { get; set; }
        public bool? liberado { get; set; }
    }
}

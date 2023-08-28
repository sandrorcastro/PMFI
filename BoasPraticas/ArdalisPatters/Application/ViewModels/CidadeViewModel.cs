namespace Application.ViewModels
{
    public partial class CidadeViewModel
    {
        public int IdCidade { get; set; }
        public int? IdUf { get; set; }
        public string Nome { get; set; } = null!;
        public int? IdPais { get; set; }
        public int? CodigoIbge { get; set; }
        public string SinCapital { get; set; } = null!;
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public virtual PaisViewModel? IdPaisNavigation { get; set; }
        public virtual UfViewModel? IdUfNavigation { get; set; }
    }
}

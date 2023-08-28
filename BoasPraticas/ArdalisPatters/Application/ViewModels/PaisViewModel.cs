namespace Application.ViewModels
{
    public partial class PaisViewModel
    {
        public PaisViewModel()
        {
            Cidades = new HashSet<CidadeViewModel>();
            Ufs = new HashSet<UfViewModel>();
        }

        public int IdPais { get; set; }
        public string Nome { get; set; } = null!;

        public virtual ICollection<CidadeViewModel> Cidades { get; set; }
        public virtual ICollection<UfViewModel> Ufs { get; set; }
    }
}

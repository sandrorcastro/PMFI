namespace MVC.Models
{
    public class Imovel
    {
        public long ImovelId { get; set; }
        public ICollection<Endereco_Entidade>? Endereco_Entidades { get; set; }
        public ICollection<Endereco>? Enderecos { get; set; }
        public ICollection<Economia_Entidade>? Economia_Entidades { get; set; }
        public ICollection<Economia>? Economias { get; set; }
    }
}

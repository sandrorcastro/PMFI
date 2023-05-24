
namespace MVC.Models
{
    public class Endereco
    {
        public long EnderecoId { get; set; }
        public ICollection<Endereco_Entidade>? Enderecos_Entidades { get; set; }
      //  public ICollection<Pessoa>? Pessoas { get; set; }
       // public ICollection<Economia>? Economias { get; set; }
       // public ICollection<Imovel>? Imoveis { get; set; }
    }
}

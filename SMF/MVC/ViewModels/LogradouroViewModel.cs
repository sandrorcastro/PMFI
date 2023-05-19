using Domain.Entities;

namespace MVC.ViewModels
{
    public class LogradouroViewModel
    {
        public long LogradouroId { get; set; }
        public string? Descricao { get; set; }
        public int? CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
        public long? BairroId { get; set; }
        public Bairro? Bairro { get; set; }
        public int? TipoLogradouroId { get; set; }   
        public TipoLogradouro? TipoLogradouro { get; set; }
        public string? descricaoTipoLogradouro { get; set; }
        public ICollection<Endereco>? Enderecos { get; set; }
        public string? CEP { get; set; }
        public bool? Ativo { get; set; }
    }
}

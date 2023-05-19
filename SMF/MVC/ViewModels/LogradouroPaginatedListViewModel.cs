using Domain.Entities;
using MVC.Models;

namespace MVC.ViewModels
{
    public class LogradouroPaginatedListViewModel : PaginatedList<Logradouro>
    {
        public LogradouroPaginatedListViewModel() { }
        public LogradouroPaginatedListViewModel(string sort, string filter)
        {
            Sort = sort;
            Filter = Filter;
        }
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

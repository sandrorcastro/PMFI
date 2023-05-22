

using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
//using Mono.TextTemplating;
using MVC.Models;

namespace MVC.ViewModels
{
    public class ImovelPaginatedListViewModel : PaginatedList<Imovel>
    {
        public ImovelPaginatedListViewModel()
        {
          //  Sort = "Nome";
        }
        public ImovelPaginatedListViewModel(string sort, string filter)
        {
            Sort = sort;
            Filter = Filter;
        }
        public long ImovelId { get; set; }
        //public ICollection<Economia>? Economias { get; set; }
        //public ICollection<EconomiaPessoa>? EconomiasPessoas { get; set; }

        public string? Matricula { get; set; }
        // public string? EdificacaoIdTemp { get; set; }
        //public string? EdificacaoNumeroOficio { get; set; }
        //   public string? EdificioCaracteristica { get; set; }
        // public string? TerrenoIdTemp { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Complemento { get; set; }
        public string? AreaTerreno { get; set; }
        public string? AreaConstruida { get; set; }
        public string? AnoConstrucao { get; set; }
        public string? Caracteristica { get; set; }
        //   public ICollection<ImovelEconomiaEndereco>? EnderecosImovel { get; set; }
        public ICollection<Endereco_Entidade>? Enderecos { get; set; }
        public ICollection<Economia_Entidade>? Economias { get; set; }



        
    }
}



using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Mono.TextTemplating;
using MVC.Models;

namespace MVC.ViewModels
{
    public class ImovelViewModel //:PaginatedList<Imovel>
        
    {
        public ImovelViewModel()
        {
            Sort = "Nome";
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



        public PaginatedList<Imovel>? Imoveis { get; set; }

        //[BindProperty(SupportsGet = true, Name = "p")]
        public int PageIndex { get; set; } = 1;

        //[BindProperty(SupportsGet = true)]
        public string? Filter { get; set; }

        //[BindProperty(SupportsGet = true)]
        public string Sort { get; set; }

        //[BindProperty(SupportsGet = true)]
        public SortDirection Direction { get; set; }

        public Dictionary<string, string> LinkData =>
           new()
           {
                {"filter", Filter},
                {"p", Imoveis.CurrentPage.ToString()},
                {"sort", Sort},
                {"direction", Direction.ToString()}
           };


        public SortDirection GetNextSortDirection(string name, SortDirection defaultOrder)
        {
            if (Sort?.ToLower() != name?.ToLower())
            {
                return defaultOrder;
            }


            return Direction == SortDirection.Asc ? SortDirection.Desc : SortDirection.Asc;
        }
    }
}

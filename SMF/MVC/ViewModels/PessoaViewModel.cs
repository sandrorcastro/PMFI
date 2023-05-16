

using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Mono.TextTemplating;
using MVC.Models;

namespace MVC.ViewModels
{
    public class PessoaViewModel // PaginatedList<Pessoa>
        
    {
        public PessoaViewModel()
        {
            Sort = "PessoaId";
        }
        public long PessoaId { get; set; }
        public string? Nome { get; set; }
        public int TipoPessoaId { get; set; }
        public TipoPessoa? TipoPessoa { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool? Ativo { get; set; }
        public long? conId { get; set; }
        public IEnumerable<Endereco_Entidade>? Enderecos { get; set; }
        public IEnumerable<DocumentoPessoa>? Documentos { get; set; }
        public IEnumerable<Economia_Entidade>? Economias { get; set; }
        public IEnumerable<Contato_Pessoa>? Contatos { get; set; }
        /// 



        public PaginatedList<Pessoa>? Pessoas { get; set; }

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
                {"pagina", Pessoas.CurrentPage.ToString()},
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

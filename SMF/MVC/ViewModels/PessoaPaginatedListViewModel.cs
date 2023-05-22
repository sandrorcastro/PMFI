

using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
//using Mono.TextTemplating;
using MVC.Models;

namespace MVC.ViewModels
{
    public class PessoaPaginatedListViewModel : PaginatedList<Pessoa>

    {
        public PessoaPaginatedListViewModel() { }
        public PessoaPaginatedListViewModel(string sort, string filter)
        {
            Sort = sort;
            Filter = Filter;
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
    } 
}

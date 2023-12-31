﻿

using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
//using Mono.TextTemplating;
using MVC.Models;

namespace MVC.ViewModels
{
    public class EconomiaPaginatedListViewModel : PaginatedList<Economia>
    {
        public EconomiaPaginatedListViewModel()
        {
            //  Sort = "Nome";
        }
        public EconomiaPaginatedListViewModel(string sort, string filter)
        {
            Sort = sort;
            Filter = Filter;
        }
        public long ImovelId { get; set; }
        public long EconomiaId { get; set; }
        public Imovel Imovel { get; set; }
        // public ICollection<Economia_Pessoa> Pessoas { get; set; }
        public ICollection<Economia_Entidade> Pessoas { get; set; }
        public ICollection<Endereco_Entidade> Enderecos { get; set; }
        //public string? EdificacaoIdTemp { get; set; }

        //public string? TerrenoIdTemp { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Complemento { get; set; }
        public string? AreaConstruida { get; set; }
        public string? AnoConstrucao { get; set; }

        public string? Numeracao { get; set; }
        public string? Caracteristica { get; set; }
        public string? Matricula { get; set; }
        public bool? TemProcessos { get; set; }
    }
}

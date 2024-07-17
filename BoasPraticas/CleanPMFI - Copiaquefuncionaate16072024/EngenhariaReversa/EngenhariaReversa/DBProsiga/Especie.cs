using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Especie
    {
        public Especie()
        {
            Acessorios = new HashSet<Acessorio>();
            AlmItens = new HashSet<AlmIten>();
            Fzveiculos = new HashSet<Fzveiculo>();
            MoveisItens = new HashSet<MoveisIten>();
            VeicSolicitacaos = new HashSet<VeicSolicitacao>();
            VeiculosItens = new HashSet<VeiculosIten>();
        }

        public int EspecieId { get; set; }
        public string? EspecieNome { get; set; }
        public string? EspeciePermanente { get; set; }
        public int? GeneroId { get; set; }

        public virtual Genero? Genero { get; set; }
        public virtual ICollection<Acessorio> Acessorios { get; set; }
        public virtual ICollection<AlmIten> AlmItens { get; set; }
        public virtual ICollection<Fzveiculo> Fzveiculos { get; set; }
        public virtual ICollection<MoveisIten> MoveisItens { get; set; }
        public virtual ICollection<VeicSolicitacao> VeicSolicitacaos { get; set; }
        public virtual ICollection<VeiculosIten> VeiculosItens { get; set; }
    }
}

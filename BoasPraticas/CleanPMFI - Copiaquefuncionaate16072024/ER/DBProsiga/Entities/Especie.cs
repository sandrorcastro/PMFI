using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Especie
{
    public int EspecieId { get; set; }

    public string? EspecieNome { get; set; }

    public string? EspeciePermanente { get; set; }

    public int? GeneroId { get; set; }

    public virtual ICollection<Acessorio> Acessorios { get; set; } = new List<Acessorio>();

    public virtual ICollection<AlmIten> AlmItens { get; set; } = new List<AlmIten>();

    public virtual ICollection<Fzveiculo> Fzveiculos { get; set; } = new List<Fzveiculo>();

    public virtual Genero? Genero { get; set; }

    public virtual ICollection<MoveisIten> MoveisItens { get; set; } = new List<MoveisIten>();

    public virtual ICollection<VeicSolicitacao> VeicSolicitacaos { get; set; } = new List<VeicSolicitacao>();

    public virtual ICollection<VeiculosIten> VeiculosItens { get; set; } = new List<VeiculosIten>();
}

using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Marca
{
    public int MarcaId { get; set; }

    public string? MarcaNome { get; set; }

    public virtual ICollection<Acessorio> Acessorios { get; set; } = new List<Acessorio>();

    public virtual ICollection<AlmIten> AlmItens { get; set; } = new List<AlmIten>();

    public virtual ICollection<Fzveiculo> Fzveiculos { get; set; } = new List<Fzveiculo>();

    public virtual ICollection<MoveisIten> MoveisItens { get; set; } = new List<MoveisIten>();

    public virtual ICollection<VeiculosIten> VeiculosItens { get; set; } = new List<VeiculosIten>();
}

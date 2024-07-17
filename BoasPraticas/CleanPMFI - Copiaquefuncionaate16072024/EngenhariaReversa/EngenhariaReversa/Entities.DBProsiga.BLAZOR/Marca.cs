using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Marca
    {
        public Marca()
        {
            Acessorios = new HashSet<Acessorio>();
            AlmItens = new HashSet<AlmIten>();
            Fzveiculos = new HashSet<Fzveiculo>();
            MoveisItens = new HashSet<MoveisIten>();
            VeiculosItens = new HashSet<VeiculosIten>();
        }

        public int MarcaId { get; set; }
        public string? MarcaNome { get; set; }

        public virtual ICollection<Acessorio> Acessorios { get; set; }
        public virtual ICollection<AlmIten> AlmItens { get; set; }
        public virtual ICollection<Fzveiculo> Fzveiculos { get; set; }
        public virtual ICollection<MoveisIten> MoveisItens { get; set; }
        public virtual ICollection<VeiculosIten> VeiculosItens { get; set; }
    }
}

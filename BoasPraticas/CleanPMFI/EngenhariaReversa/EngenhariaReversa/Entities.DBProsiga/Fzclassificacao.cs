using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Fzclassificacao
    {
        public Fzclassificacao()
        {
            Fzveiculos = new HashSet<Fzveiculo>();
        }

        public int FzclassifVeiId { get; set; }
        public string? FzclassifVeiNome { get; set; }

        public virtual ICollection<Fzveiculo> Fzveiculos { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Combustivel
    {
        public Combustivel()
        {
            CombustivelDepositos = new HashSet<CombustivelDeposito>();
            Fzveiculos = new HashSet<Fzveiculo>();
            Veiculos = new HashSet<Veiculo>();
        }

        public int CombustivelId { get; set; }
        public string? CombNome { get; set; }

        public virtual ICollection<CombustivelDeposito> CombustivelDepositos { get; set; }
        public virtual ICollection<Fzveiculo> Fzveiculos { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Combustivel
{
    public int CombustivelId { get; set; }

    public string? CombNome { get; set; }

    public virtual ICollection<CombustivelDeposito> CombustivelDepositos { get; set; } = new List<CombustivelDeposito>();

    public virtual ICollection<Fzveiculo> Fzveiculos { get; set; } = new List<Fzveiculo>();

    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}

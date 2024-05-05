using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Fztaxa
{
    public int TxId { get; set; }

    public string? TxNome { get; set; }

    public decimal? TxCoeficiente { get; set; }

    public int? TxReferId { get; set; }

    /// <summary>
    /// Código de identificação da receita contábil.
    /// </summary>
    public string? CodReceita { get; set; }

    public virtual ICollection<FzautoInfracoesIten> FzautoInfracoesItens { get; set; } = new List<FzautoInfracoesIten>();

    public virtual ICollection<Fzdivida> Fzdivida { get; set; } = new List<Fzdivida>();

    public virtual Fzreferencia? TxRefer { get; set; }

    public virtual ICollection<FztipoVistorium> FztipoVists { get; set; } = new List<FztipoVistorium>();
}

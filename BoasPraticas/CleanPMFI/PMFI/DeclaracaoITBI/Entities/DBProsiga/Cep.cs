using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Cep
{
    public int IdEndereco { get; set; }

    public int? IdCidade { get; set; }

    public int? Idlogradouro { get; set; }

    public int? IdBairro { get; set; }

    public string? Cep1 { get; set; }

    public bool? FlExcluido { get; set; }

    public virtual ICollection<TbConSolicitacaoInscricaoCmc> TbConSolicitacaoInscricaoCmcs { get; set; } = new List<TbConSolicitacaoInscricaoCmc>();
}

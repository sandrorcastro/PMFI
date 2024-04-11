using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscCategoriaEstabelecimento
{
    public int CategEstId { get; set; }

    public string? CategEstCodigo { get; set; }

    public string? CategEstDescricao { get; set; }

    public virtual ICollection<TribFiscCategoriaEstabelecimentoCnae> TribFiscCategoriaEstabelecimentoCnaes { get; set; } = new List<TribFiscCategoriaEstabelecimentoCnae>();

    public virtual ICollection<TribFiscProcedimento> TribFiscProcedimentos { get; set; } = new List<TribFiscProcedimento>();
}

using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscTipoFiscal
{
    public int TipoFiscId { get; set; }

    public string? TipoFiscDescricao { get; set; }

    public virtual ICollection<TribFiscFiscai> TribFiscFiscais { get; set; } = new List<TribFiscFiscai>();

    public virtual ICollection<TribFiscOrdemServico> TribFiscOrdemServicos { get; set; } = new List<TribFiscOrdemServico>();

    public virtual ICollection<TribFiscProcedimento> TribFiscProcedimentos { get; set; } = new List<TribFiscProcedimento>();

    public virtual ICollection<TribFiscReclamaco> TribFiscReclamacos { get; set; } = new List<TribFiscReclamaco>();

    public virtual ICollection<TribFiscTipoReclamacao> TribFiscTipoReclamacaos { get; set; } = new List<TribFiscTipoReclamacao>();

    public virtual ICollection<TribFiscTiposVistorium> TipoVists { get; set; } = new List<TribFiscTiposVistorium>();
}

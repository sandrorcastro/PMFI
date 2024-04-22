using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscTermoDeDevolucao
{
    public int FiscIdtermoDevolucao { get; set; }

    public long? TextoId { get; set; }

    public string? FiscProntuario { get; set; }

    public string? FiscMotivo { get; set; }

    public string? FiscUsuario { get; set; }

    public DateTime? FiscDataInclusao { get; set; }

    public string? FiscSituacao { get; set; }

    public virtual ICollection<TribFiscTermoDeDevolucaoDocumento> TribFiscTermoDeDevolucaoDocumentos { get; set; } = new List<TribFiscTermoDeDevolucaoDocumento>();

    public virtual ICollection<TribFiscTermoDeRetencao> FiscIdtermoRetencaos { get; set; } = new List<TribFiscTermoDeRetencao>();
}

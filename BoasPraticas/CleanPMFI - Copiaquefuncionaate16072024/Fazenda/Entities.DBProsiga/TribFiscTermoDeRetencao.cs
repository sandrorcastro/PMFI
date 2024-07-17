using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscTermoDeRetencao
{
    public int FiscIdtermoRetencao { get; set; }

    public long? TextoId { get; set; }

    public long? EmprCmc { get; set; }

    public long? ConId { get; set; }

    public string? FiscProntuario { get; set; }

    public string? FiscMotivo { get; set; }

    public string? FiscUsuario { get; set; }

    public DateTime? FiscDataInclusao { get; set; }

    public string? FiscSituacao { get; set; }

    public virtual ICollection<TribFiscTermoDeRetencaoDocumento> TribFiscTermoDeRetencaoDocumentos { get; set; } = new List<TribFiscTermoDeRetencaoDocumento>();

    public virtual ICollection<TribFiscTermoDeDevolucao> FiscIdtermoDevolucaos { get; set; } = new List<TribFiscTermoDeDevolucao>();
}

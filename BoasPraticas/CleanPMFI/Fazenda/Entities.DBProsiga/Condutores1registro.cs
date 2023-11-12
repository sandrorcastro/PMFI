using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Condutores1registro
{
    public string? Nome { get; set; }

    public string? Categoria { get; set; }

    public string? NumRegistro { get; set; }

    public DateTime? Dtnascimento { get; set; }

    public DateTime? DtprimHabilitacao { get; set; }

    public DateTime? Dtexpedicao { get; set; }

    public string? Ufemitente { get; set; }

    public string? CidadeEmitente { get; set; }

    public long IdCondutor { get; set; }

    public DateTime? DtvalidadeCnh { get; set; }

    public int? DivId { get; set; }

    public string? ComFoto { get; set; }

    public string? Obs { get; set; }

    public virtual ICollection<CombustivelSaidum> CombustivelSaida { get; set; } = new List<CombustivelSaidum>();

    public virtual ICollection<XFrotaMovOrdensServico> XFrotaMovOrdensServicos { get; set; } = new List<XFrotaMovOrdensServico>();
}

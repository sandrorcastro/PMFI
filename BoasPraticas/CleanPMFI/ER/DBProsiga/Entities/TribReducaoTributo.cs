using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribReducaoTributo
{
    public int IdReducao { get; set; }

    public DateTime? DtReducao { get; set; }

    public int? NrExercicio { get; set; }

    public long? EdificacaoId { get; set; }

    public long? EmprCmc { get; set; }

    public long? ConId { get; set; }

    public string? DsReducao { get; set; }

    public int? NrProtocolo { get; set; }

    public int? NrAnoProtocolo { get; set; }

    public string? TpReducao { get; set; }

    public int? TipoBxId { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public int? NrNumCda { get; set; }

    public int? NrAnoCda { get; set; }

    public int? TipoDivId { get; set; }

    public virtual ICollection<TribReducaoTributosIten> TribReducaoTributosItens { get; set; } = new List<TribReducaoTributosIten>();
}

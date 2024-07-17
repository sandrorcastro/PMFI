using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEdificacoesIsencao
{
    public int IsencaoId { get; set; }

    public long? EdificacaoId { get; set; }

    public DateTime? DataIsencao { get; set; }

    public int? ProcId { get; set; }

    public string? Motivo { get; set; }

    public int? TipoIseId { get; set; }

    public DateTime? ExeInicial { get; set; }

    public DateTime? ExeFinal { get; set; }

    public string? NrProcessoNumAno { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }

    public virtual TribTipoIsencao? TipoIse { get; set; }

    public virtual ICollection<TribEdificacoesIsencaoTrib> TribEdificacoesIsencaoTribs { get; set; } = new List<TribEdificacoesIsencaoTrib>();
}

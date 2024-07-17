using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribProtestoLote
{
    public int IdLote { get; set; }

    public DateTime? DtLote { get; set; }

    public string? FlSituacao { get; set; }

    public string? DsNomeArquivo { get; set; }

    public string? DsNomeArquivoRetorno { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsUsuarioInclusao { get; set; }

    public long? LoteNumero { get; set; }

    public short? LoteAno { get; set; }

    public int? IdDivisao { get; set; }

    public virtual Diviso? IdDivisaoNavigation { get; set; }

    public virtual ICollection<TribProtestoLoteCdum> TribProtestoLoteCda { get; set; } = new List<TribProtestoLoteCdum>();

    public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDivida { get; set; } = new List<TribProtestoLoteCdahistoricoSituacaoDividum>();
}

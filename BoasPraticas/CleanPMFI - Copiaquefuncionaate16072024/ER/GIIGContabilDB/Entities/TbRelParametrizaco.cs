using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRelParametrizaco
{
    public short IdRelatorio { get; set; }

    public string? NmRelatorio { get; set; }

    public string? DsRelatorio { get; set; }

    public string? DsFormatacaoPeriodo { get; set; }

    public string? DsAnexo { get; set; }

    public string? DsMoedaReferencia { get; set; }

    public string? DsFonte { get; set; }

    public string? DsTipo { get; set; }

    public string? DsNotas { get; set; }

    public string? NmRptCrystal { get; set; }

    public short? NrProcessaAnosAnteriores { get; set; }

    public short? NrAno { get; set; }

    public virtual ICollection<TbRelParametrizacoesGrupo> TbRelParametrizacoesGrupos { get; set; } = new List<TbRelParametrizacoesGrupo>();
}

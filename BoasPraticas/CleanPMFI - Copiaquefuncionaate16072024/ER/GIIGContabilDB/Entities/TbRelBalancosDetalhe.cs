using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRelBalancosDetalhe
{
    public int IdDetalhe { get; set; }

    public short? IdRelatorio { get; set; }

    public short Sequencia { get; set; }

    public string? DsTituloDetalhe { get; set; }

    public string? DsTipoSecao { get; set; }

    public string? CdCodigo { get; set; }

    public int? IdDetalheReferencia { get; set; }

    public virtual TbRelBalanco? IdRelatorioNavigation { get; set; }
}

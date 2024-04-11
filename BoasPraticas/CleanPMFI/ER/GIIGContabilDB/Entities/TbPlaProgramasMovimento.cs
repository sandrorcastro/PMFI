using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaProgramasMovimento
{
    public int IdMovimento { get; set; }

    public int? IdPrograma { get; set; }

    public short? NrMovimento { get; set; }

    public short? IdTipoMovimento { get; set; }

    public DateTime? DtMovimento { get; set; }

    public string? NmPrograma { get; set; }

    public bool? FlFinalistico { get; set; }

    public string? DsObjetivo { get; set; }

    public int? IdVersaoMovimento { get; set; }

    public string? DsPrograma { get; set; }

    public string? DsNotaExplicativa { get; set; }

    public virtual TbPlaPrograma? IdProgramaNavigation { get; set; }

    public virtual TbPlaTiposMovimento? IdTipoMovimentoNavigation { get; set; }

    public virtual TbPlaVerso? IdVersaoMovimentoNavigation { get; set; }
}

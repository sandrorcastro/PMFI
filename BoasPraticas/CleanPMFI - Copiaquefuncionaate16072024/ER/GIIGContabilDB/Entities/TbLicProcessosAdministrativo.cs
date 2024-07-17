using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicProcessosAdministrativo
{
    public int IdProcAdm { get; set; }

    public short? IdSetorCompra { get; set; }

    public string? NrProcAdm { get; set; }

    public short? IdModalidade { get; set; }

    public short? IdNaturezaProcedimento { get; set; }

    public string? DsProcAdm { get; set; }

    public int? IdRms { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public virtual ICollection<TbDspEmpenho> IdEmpenhos { get; set; } = new List<TbDspEmpenho>();
}

using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPpaIndicadore
{
    public short IdEmpresa { get; set; }

    public short NrAnoPpa { get; set; }

    public short NrVersao { get; set; }

    public int CdIndicador { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdPrograma { get; set; }

    public string? DsIndicador { get; set; }

    public short? IdUnidadeMedida { get; set; }

    public string? DsMedida { get; set; }

    public DateTime? DtBase { get; set; }

    public string? DsIndiceFinal { get; set; }

    public int? IdPublicoAlvo { get; set; }

    public string? DsTpComando { get; set; }

    public int? IdTipoIndicador { get; set; }

    public virtual TbPpaPublicosAlvo? IdPublicoAlvoNavigation { get; set; }

    public virtual TbPpaUnidadesMedidum? IdUnidadeMedidaNavigation { get; set; }

    public virtual TbPpaPrograma? TbPpaPrograma { get; set; }
}

using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmTermosAditivoConvenio
{
    public int IdTermo { get; set; }

    public short? IdEmpresa { get; set; }

    public string? CdConvenioAuxilio { get; set; }

    public DateTime? DtAditivo { get; set; }

    public string? NrDoe { get; set; }

    public short? NrAnoDoe { get; set; }

    public DateTime? DtPublicacaoDoe { get; set; }

    public DateTime? DtPrazoVigencia { get; set; }

    public decimal? VlAditivo { get; set; }

    public decimal? VlContrapartida { get; set; }

    public string? DsAditivo { get; set; }

    public string? DsOutrasClausulas { get; set; }
}

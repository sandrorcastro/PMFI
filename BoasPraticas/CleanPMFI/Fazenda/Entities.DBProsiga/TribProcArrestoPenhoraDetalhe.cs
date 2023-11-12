using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribProcArrestoPenhoraDetalhe
{
    public long ProcArrDetId { get; set; }

    public long? ProcArrId { get; set; }

    public string? ProcArrExequente { get; set; }

    public DateTime? ProcArrExequenteData { get; set; }

    public string? ProcArrAceita { get; set; }

    public string? ProcArrCreditoGarantido { get; set; }

    public string? ProcArrReforcoPenhora { get; set; }

    public string? ProcArrGarantiaSuficiente { get; set; }

    public string? ProcArrTipoBem { get; set; }

    public string? ProcArrDescricaoBem { get; set; }

    public string? ProcArrMotivoPeticao { get; set; }

    public string? ProcArrPeticao { get; set; }

    public DateTime? ProcArrDataPeticao { get; set; }

    public DateTime? ProcArrDataConvertidoPenhora { get; set; }

    public virtual TribProcArrestoPenhora? ProcArr { get; set; }
}

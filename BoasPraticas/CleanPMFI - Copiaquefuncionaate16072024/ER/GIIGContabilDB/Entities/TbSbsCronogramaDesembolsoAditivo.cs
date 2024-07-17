using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsCronogramaDesembolsoAditivo
{
    public int IdCronogAditivo { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdAditivo { get; set; }

    public int? IdNatDespesa { get; set; }

    public DateTime? DtDesembolso { get; set; }

    public decimal? VlDesembolso { get; set; }

    public virtual TbSbsAditivo? IdAditivoNavigation { get; set; }

    public virtual TbOrcNaturezasDespesa? IdNatDespesaNavigation { get; set; }
}

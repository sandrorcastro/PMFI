using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbImoMovObrasDepuDesp
{
    public int IdmovObrasDepuDesp { get; set; }

    public long ImoTbImoMovObrasIdObra { get; set; }

    public int NroDepuDespNum { get; set; }

    public short NroDepuDespAno { get; set; }

    public string DsDePuTipoDespesa { get; set; } = null!;

    public decimal? VlDepuDespValor { get; set; }

    public DateTime? DtDespesa { get; set; }

    public virtual TbImoMovimentoObra ImoTbImoMovObrasIdObraNavigation { get; set; } = null!;
}

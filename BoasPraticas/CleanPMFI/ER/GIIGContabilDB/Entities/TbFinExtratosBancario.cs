using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinExtratosBancario
{
    public int IdExtrato { get; set; }

    public short? IdEmpresa { get; set; }

    public int? IdCc { get; set; }

    public DateTime? DtExtrato { get; set; }

    public string? DsHistorico { get; set; }

    public string? NrDocumento { get; set; }

    public decimal? VlExtrato { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual ICollection<TbFinCompensacaoDiarioTesourarium> TbFinCompensacaoDiarioTesouraria { get; set; } = new List<TbFinCompensacaoDiarioTesourarium>();

    public virtual ICollection<TbFinConciliacoesBancaria> TbFinConciliacoesBancaria { get; set; } = new List<TbFinConciliacoesBancaria>();

    public virtual ICollection<TbFinContasContabeisLancamento> IdLancamentos { get; set; } = new List<TbFinContasContabeisLancamento>();
}

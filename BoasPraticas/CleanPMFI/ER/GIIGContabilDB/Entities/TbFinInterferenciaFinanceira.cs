using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinInterferenciaFinanceira
{
    public int IdInterferencia { get; set; }

    public int? IdLancamento { get; set; }

    public short? IdEmpresa { get; set; }

    public string? TpInterferencia { get; set; }

    public int? IdFonte { get; set; }

    public string? TpOperacao { get; set; }

    public short? NrTransferencia { get; set; }

    public short? NrAnoTransferencia { get; set; }

    public DateTime? DtInterferencia { get; set; }

    public decimal? VlInterferencia { get; set; }

    public int? IdDespesa { get; set; }

    public short? IdEmpresaInterferencia { get; set; }

    public short? TpNaturezaTransferencia { get; set; }

    public int? IdCcempresaInterferencia { get; set; }

    public virtual TbFinContasContabeisLancamento? IdLancamentoNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinDividaFundadum
{
    public long IdDividaFundada { get; set; }

    public short? IdEmpresa { get; set; }

    public int? NrDivida { get; set; }

    public short? NrAnoDivida { get; set; }

    public string? CdContaContabilLongoPrazo { get; set; }

    public string? CdContaContabil { get; set; }

    public string? CdContaContabilAmortizacao { get; set; }

    public string? CdContaContabilReajuste { get; set; }

    public string? CdContaContabilEmprestimo { get; set; }

    public int? CdTipoConta { get; set; }

    public int? IdClasseOperacaoCredito { get; set; }

    public string NrContratoDivida { get; set; } = null!;

    public int? IdLeiAtoAutorizatoria { get; set; }

    public string? NrLeiAutorizatoria { get; set; }

    public DateTime? DtLeiAutorizatoria { get; set; }

    public string? NrOficioStn { get; set; }

    public DateTime? DtOficioStn { get; set; }

    public string DsContrato { get; set; } = null!;

    public decimal? VlDivida { get; set; }

    public int? NrQtdParcelas { get; set; }

    public int? NrQtdParcelasPagas { get; set; }

    public DateTime? DtAssinaturaContrato { get; set; }

    public virtual TbFinClassesOperacoesCredito? IdClasseOperacaoCreditoNavigation { get; set; }

    public virtual ICollection<TbFinLancamentosPermutaDividaFundadum> TbFinLancamentosPermutaDividaFundada { get; set; } = new List<TbFinLancamentosPermutaDividaFundadum>();
}

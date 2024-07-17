using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbDivLancamentoCredito
{
    public int IdCredito { get; set; }

    public string? TpCredito { get; set; }

    public int? NrCredito { get; set; }

    public short? NrAnoCredito { get; set; }

    public short? IdTipoCredito { get; set; }

    public short? IdTipoOperacaoCredito { get; set; }

    public int? TipoTribId { get; set; }

    public DateTime? DtLancamento { get; set; }

    public short? NrMesBase { get; set; }

    public short? NrAnoBase { get; set; }

    public short? NrAnoInscricao { get; set; }

    public int? IdLeiAto { get; set; }

    public string? TpDocContribuinte { get; set; }

    public string? NrDocContribuinte { get; set; }

    public string? NmContribuinte { get; set; }

    public decimal? VlCredito { get; set; }

    public string? CdReceita { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLoginInclusao { get; set; }

    public int? IdCreditoOrigem { get; set; }

    public short? TpCadastro { get; set; }

    public long? IdCadastro { get; set; }

    public DateTime? DtUltimaCorrecao { get; set; }

    public short? IdTipoOperacaoReceita { get; set; }

    public virtual ICollection<TbDivDividaAtivaJudicial> TbDivDividaAtivaJudicials { get; set; } = new List<TbDivDividaAtivaJudicial>();

    public virtual ICollection<TbDivInscricaoSancao> TbDivInscricaoSancaos { get; set; } = new List<TbDivInscricaoSancao>();

    public virtual ICollection<TbDivLancamentoAtualizacaoMonetariaCredito> TbDivLancamentoAtualizacaoMonetariaCreditos { get; set; } = new List<TbDivLancamentoAtualizacaoMonetariaCredito>();

    public virtual ICollection<TbDivLancamentoCreditoComposicao> TbDivLancamentoCreditoComposicaos { get; set; } = new List<TbDivLancamentoCreditoComposicao>();

    public virtual ICollection<TbDivLancamentoCreditoEstorno> TbDivLancamentoCreditoEstornos { get; set; } = new List<TbDivLancamentoCreditoEstorno>();

    public virtual ICollection<TbDivLancamentoDeducaoCredito> TbDivLancamentoDeducaoCreditos { get; set; } = new List<TbDivLancamentoDeducaoCredito>();

    public virtual ICollection<TbDivParcelamentoCredito> TbDivParcelamentoCreditos { get; set; } = new List<TbDivParcelamentoCredito>();
}

using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinContasContabeisLancamento
{
    public int IdLancamento { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public int? NrSequencial { get; set; }

    public int IdContaContabilDebito { get; set; }

    public int IdContaContabilCredito { get; set; }

    public DateTime? DtLancamento { get; set; }

    public decimal? VlLancamento { get; set; }

    public string? DsOrigem { get; set; }

    public string? DsHistorico { get; set; }

    /// <summary>
    /// Empenho, RMS, Solicitação Adicional, Bloqueio de Programação
    /// </summary>
    public string? DsObjeto { get; set; }

    public long? DsNumObjeto { get; set; }

    public string? DsSigla { get; set; }

    public short? IdTipoDocFinanceiro { get; set; }

    public string? NrDocFinanceiro { get; set; }

    public string? DsLogin { get; set; }

    public string? DsEnderecoIp { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? FlEstorno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public int? CdEvento { get; set; }

    public int? CdHistorico { get; set; }

    public short? IdTipoOperacaoFinanceira { get; set; }

    public int? IdLancamentoEstorno { get; set; }

    public virtual ICollection<TbFinDiarioTesourarium> TbFinDiarioTesouraria { get; set; } = new List<TbFinDiarioTesourarium>();

    public virtual ICollection<TbFinInterferenciaFinanceira> TbFinInterferenciaFinanceiras { get; set; } = new List<TbFinInterferenciaFinanceira>();

    public virtual ICollection<TbFinLancamentosPartidaDobrada> TbFinLancamentosPartidaDobrada { get; set; } = new List<TbFinLancamentosPartidaDobrada>();

    public virtual ICollection<TbFinExtratosBancario> IdExtratos { get; set; } = new List<TbFinExtratosBancario>();
}

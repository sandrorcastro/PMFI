using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcDotacoesMovimentacao
{
    public int IdMovimento { get; set; }

    public int? IdDotacao { get; set; }

    public DateTime? DtMovimento { get; set; }

    public decimal? VlMovimento { get; set; }

    public string? DsTipo { get; set; }

    public string? DsOrigem { get; set; }

    public string? DsOcorrencia { get; set; }

    public string? DsLogin { get; set; }

    /// <summary>
    /// Empenho, RMS, Solicitação Adicional, Bloqueio de Programação
    /// </summary>
    public string? DsObjeto { get; set; }

    public string? DsNumObjeto { get; set; }

    public DateTime? DtObjeto { get; set; }

    public int? IdSubAcaoTarefa { get; set; }

    public virtual TbOrcDotaco? IdDotacaoNavigation { get; set; }
}

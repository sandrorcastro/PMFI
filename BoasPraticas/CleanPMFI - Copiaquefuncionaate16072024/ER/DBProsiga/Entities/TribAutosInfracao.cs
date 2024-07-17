using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAutosInfracao
{
    public long AutoInfrId { get; set; }

    public long? EmprCmc { get; set; }

    public long? EdificacaoId { get; set; }

    public long? ConId { get; set; }

    public int? TipoTribId { get; set; }

    public int? AutInfrAno { get; set; }

    public int? AutInfrNum { get; set; }

    public DateTime? AutInfrDataAuto { get; set; }

    public string? AutInfrInfracao { get; set; }

    public string? AutInfrLegislacao { get; set; }

    public string? AutInfrMoeda { get; set; }

    public decimal? AutInfrValor { get; set; }

    public DateTime? AutInfrVencimento { get; set; }

    public string? AutInfrFiscalizado { get; set; }

    public DateTime? AutInfrDataNotif { get; set; }

    /// <summary>
    /// Percentual de desconto para pagamento antecipado.
    /// </summary>
    public decimal? AutInfrPercDescPagtoAntecipado { get; set; }

    public decimal? AutInfrPercDescPagto { get; set; }

    public int? AutInfrQtdeDiasPagtoAntecipado { get; set; }

    public int? AutInfrQtdeDiasPagto { get; set; }

    public string? AutInfrRemovido { get; set; }

    /// <summary>
    /// Vencimento para pagamento antecipado da divida.
    /// </summary>
    public DateTime? AutInfrVencPgtoAntecipado { get; set; }

    /// <summary>
    /// Marca se o auto de infração ira gerar dívidas com parcela única e desconto.
    /// </summary>
    public string AutInfrDesconto { get; set; } = null!;

    public short? Idmoeda { get; set; }

    public string? AutInfrDesObs { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }

    public virtual TribEmpresa? EmprCmcNavigation { get; set; }

    public virtual Moeda? IdmoedaNavigation { get; set; }

    public virtual ICollection<TribDividasImo> TribDividasImos { get; set; } = new List<TribDividasImo>();
}

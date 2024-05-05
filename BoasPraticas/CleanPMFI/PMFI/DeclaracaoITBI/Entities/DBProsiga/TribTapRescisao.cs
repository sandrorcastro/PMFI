using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribTapRescisao
{
    public int ResId { get; set; }

    public long? TapId { get; set; }

    public DateTime? DataRescisao { get; set; }

    public string? Motivo { get; set; }

    public long? TextoId { get; set; }

    public decimal? TotalPagamento { get; set; }

    public decimal? TotalCorrecao { get; set; }

    public decimal? TotalDividaOrigem { get; set; }

    public string? Proporcional { get; set; }

    public string? AlteradoSimulaAutom { get; set; }

    /// <summary>
    /// Identificação da Devolução da Receita
    /// </summary>
    public long? BaDeId { get; set; }

    public string? ComDesconto { get; set; }

    public decimal? SaldoRestituir { get; set; }

    public string? Termo { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? HostInclusao { get; set; }

    public decimal? TotalSemJurosMulta { get; set; }

    public decimal? TotalJurosTap { get; set; }

    public decimal? TotalDeduzir { get; set; }

    public int? ObjetoId { get; set; }

    public virtual ICollection<TribTapRescisaoMapa> TribTapRescisaoMapas { get; set; } = new List<TribTapRescisaoMapa>();
}

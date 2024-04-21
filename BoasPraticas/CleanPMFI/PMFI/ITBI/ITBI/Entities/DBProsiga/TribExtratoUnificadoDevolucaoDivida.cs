using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribExtratoUnificadoDevolucaoDivida
{
    public string Sessao { get; set; } = null!;

    public string? TipoCadastro { get; set; }

    public int Idinscricao { get; set; }

    public string? Inscricao { get; set; }

    public string? Requerente { get; set; }

    public DateTime? DataDevolucao { get; set; }

    public decimal? VlrDevolucao { get; set; }

    public short? Ano { get; set; }

    public string? Tributo { get; set; }

    public int? SubDivida { get; set; }

    public string? Parcela { get; set; }

    public int? Mes { get; set; }

    public DateTime? Vencimento { get; set; }

    public string? TipoDivida { get; set; }

    public string? TipoBaixa { get; set; }

    public DateTime? DataBaixa { get; set; }

    public decimal? VlrBaixa { get; set; }

    public decimal? VlrDivida { get; set; }
}

using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class InscricaoDafoztran
{
    public string? TipoDocumento { get; set; }

    public string? Documento { get; set; }

    public string? NomeDevedor { get; set; }

    public string? IdTributo { get; set; }

    public string? NomeDoTributo { get; set; }

    public string? SubDivida { get; set; }

    public string? Parcela { get; set; }

    public string? Ano { get; set; }

    public string? Mês { get; set; }

    public string? DataDeGeração { get; set; }

    public string? Usuário { get; set; }

    public string? Observação { get; set; }

    public string? ValorPrincipal { get; set; }

    public string? ValorJuros { get; set; }

    public string? ValorMulta { get; set; }

    public string? ValorMultaDa { get; set; }

    public string? ValorCorreção { get; set; }

    public string? ValorDesconto { get; set; }

    public string? ValorTotal { get; set; }

    public string? Vencimento { get; set; }

    public string? ValorBaixa { get; set; }

    public string? Situação { get; set; }

    public string? DataBaixa { get; set; }

    public string? QtdeBaixa { get; set; }
}

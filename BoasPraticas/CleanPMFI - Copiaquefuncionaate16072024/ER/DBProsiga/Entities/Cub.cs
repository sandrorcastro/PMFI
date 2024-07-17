using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Cub
{
    public int Id { get; set; }

    public string? Inscricao { get; set; }

    public string? Situacao { get; set; }

    public decimal? Valor { get; set; }

    public int? Ano { get; set; }

    public string? Tipodivida { get; set; }

    public string? Tributo { get; set; }

    public string? Logradouro { get; set; }

    public string? Loteamento { get; set; }

    public int? AnoPg { get; set; }

    public int? MesPg { get; set; }

    public int? DiaPg { get; set; }

    public DateTime? Vencimento { get; set; }

    public string? TipoPg { get; set; }

    public string? Nome { get; set; }

    public string? Cpf { get; set; }

    public string? Tipodocumento { get; set; }

    public string? Tipoimovel { get; set; }

    public string? Estrutura { get; set; }

    public string? Tipoconstrucao { get; set; }

    public string? Estado { get; set; }
}

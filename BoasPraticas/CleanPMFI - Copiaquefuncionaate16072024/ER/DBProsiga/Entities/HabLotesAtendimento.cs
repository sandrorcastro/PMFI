using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class HabLotesAtendimento
{
    public string InscricaoImobiliaria { get; set; } = null!;

    public int? Status { get; set; }

    public string? UsuId { get; set; }

    public DateTime DtCadastro { get; set; }

    public string? Observacao { get; set; }

    public decimal? ValorTerreno { get; set; }

    public string? ImobiliariaOrigem { get; set; }

    public virtual Usuario? Usu { get; set; }
}

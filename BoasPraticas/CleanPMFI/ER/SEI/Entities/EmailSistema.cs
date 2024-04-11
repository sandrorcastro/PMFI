using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class EmailSistema
{
    public int IdEmailSistema { get; set; }

    public string Descricao { get; set; } = null!;

    public string De { get; set; } = null!;

    public string Para { get; set; } = null!;

    public string Assunto { get; set; } = null!;

    public string Conteudo { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public string? IdEmailSistemaModulo { get; set; }
}

using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeExamesSolicitado
{
    public int TipoExameId { get; set; }

    public int AtendId { get; set; }

    public DateTime? Data { get; set; }

    public string? Observacao { get; set; }

    public string? Situacao { get; set; }

    public string? UsuarioInclusao { get; set; }
}

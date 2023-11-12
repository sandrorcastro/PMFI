using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class GeralLembrete
{
    public int LembId { get; set; }

    public DateTime? LembData { get; set; }

    public string? LembAssunto { get; set; }

    public string? LembLembrar { get; set; }

    public string? LembUsuario { get; set; }

    public virtual Usuario? LembUsuarioNavigation { get; set; }
}

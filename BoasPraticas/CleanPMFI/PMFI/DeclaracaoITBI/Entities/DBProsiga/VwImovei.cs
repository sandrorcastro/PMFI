using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class VwImovei
{
    public string InscricaoImobiliaria { get; set; } = null!;

    public string? LogradTipo { get; set; }

    public string? LogradNome { get; set; }

    public string? Descricao { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Cep { get; set; }
}

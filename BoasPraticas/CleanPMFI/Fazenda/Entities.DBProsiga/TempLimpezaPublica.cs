using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TempLimpezaPublica
{
    public long? EdificacaoId { get; set; }

    public string? InscricaoImobiliaria { get; set; }

    public decimal? Area { get; set; }
}

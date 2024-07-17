using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ParametroAssinatura
{
    public long IdparamAssinatura { get; set; }

    public string? Descricao { get; set; }

    public long IdtipoDoc { get; set; }

    public string? EstadoAgrupamento { get; set; }

    public virtual ICollection<AssinaturasComposicao> AssinaturasComposicaos { get; set; } = new List<AssinaturasComposicao>();

    public virtual TiposDocumentosOficiai IdtipoDocNavigation { get; set; } = null!;
}

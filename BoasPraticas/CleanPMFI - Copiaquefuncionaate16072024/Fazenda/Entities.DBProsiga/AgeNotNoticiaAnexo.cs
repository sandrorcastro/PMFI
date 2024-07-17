using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class AgeNotNoticiaAnexo
{
    public long IdanexoNoticia { get; set; }

    public int? Idnoticia { get; set; }

    public string? Texto { get; set; }

    public string? TipoAnexo { get; set; }

    public byte[]? Objeto { get; set; }

    public string? Padrao { get; set; }

    public string? Extensao { get; set; }

    public virtual AgeNotNoticia? IdnoticiaNavigation { get; set; }
}

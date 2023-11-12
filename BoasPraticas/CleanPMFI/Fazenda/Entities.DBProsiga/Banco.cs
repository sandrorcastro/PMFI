using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Banco
{
    public string BancoId { get; set; } = null!;

    public string? BcoNome { get; set; }

    public string? BcoRede { get; set; }

    public string? BcoTecUltAlt { get; set; }

    public DateTime? BcoDtUltAlt { get; set; }

    public byte[]? BcoLogo { get; set; }

    public string? BcoDv { get; set; }

    public virtual ICollection<Agencium> Agencia { get; set; } = new List<Agencium>();

    public virtual ICollection<ConvenioRegistrado> ConvenioRegistrados { get; set; } = new List<ConvenioRegistrado>();
}

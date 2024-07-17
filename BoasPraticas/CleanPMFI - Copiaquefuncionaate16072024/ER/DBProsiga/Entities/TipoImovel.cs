using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TipoImovel
{
    public long TpImovelId { get; set; }

    public string TpImovelDesc { get; set; } = null!;

    public virtual ICollection<ImobensImovei> ImobensImoveis { get; set; } = new List<ImobensImovei>();

    public virtual ICollection<Imovei> Imoveis { get; set; } = new List<Imovei>();
}

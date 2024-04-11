using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class GrupoImobensMovimento
{
    public long IdGrupoImobensMov { get; set; }

    public long? MovImoNumLanc { get; set; }

    public string? ImoInscricao { get; set; }

    public string? ImoCnpjFilial { get; set; }

    public virtual ImobensImovei? Imo { get; set; }

    public virtual ImobensMovimento? MovImoNumLancNavigation { get; set; }
}

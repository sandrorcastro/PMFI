using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Agencium
{
    public string AgenciaId { get; set; } = null!;

    public string AgBancoId { get; set; } = null!;

    public string? AgNome { get; set; }

    public string? AgCredenciamento { get; set; }

    public string AgDv { get; set; } = null!;

    public string? AgTecUltAlt { get; set; }

    public DateTime? AgDtUltAlt { get; set; }

    public virtual Banco AgBanco { get; set; } = null!;

    public virtual ICollection<AguaCobrancaBanco> AguaCobrancaBancos { get; set; } = new List<AguaCobrancaBanco>();
}

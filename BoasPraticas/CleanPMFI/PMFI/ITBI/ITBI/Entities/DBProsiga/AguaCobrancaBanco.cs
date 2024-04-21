using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AguaCobrancaBanco
{
    public int CobrancaBancoId { get; set; }

    public int? HidroId { get; set; }

    public string? AgenciaId { get; set; }

    public string? AgBancoId { get; set; }

    public string? CobBancoContaCorr { get; set; }

    public string? CobBancoAtivo { get; set; }

    public virtual Agencium? Agencium { get; set; }

    public virtual AguaHidrometro? Hidro { get; set; }
}

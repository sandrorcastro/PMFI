using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class AguaCobrancaBanco
{
    public int CobrancaBancoId { get; set; }

    public int? HidroId { get; set; }

    public string? AgenciaId { get; set; }

    public string? AgBancoId { get; set; }

    public string? CobBancoContaCorr { get; set; }

    public string? CobBancoAtivo { get; set; }

    public virtual Agencium? Ag { get; set; }

    public virtual AguaHidrometro? Hidro { get; set; }
}

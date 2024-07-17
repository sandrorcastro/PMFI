using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ProdRurProprRurViasAcesso
{
    public int Idpropriedade { get; set; }

    public int LogradId { get; set; }

    public DateTime? DataCadastro { get; set; }

    public decimal? DistanciaSedeKm { get; set; }

    public virtual ProdRurPropriedade IdpropriedadeNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class AguaRuraisHidrometro
{
    public int RuralHidroId { get; set; }

    public int? HidroId { get; set; }

    public int? Idpropriedade { get; set; }

    public string? RuralHidroEndHidro { get; set; }

    public DateTime? RuralHidroDataInicio { get; set; }

    public DateTime? RuralHidroDataFinal { get; set; }

    public string? RuralHidroHistorico { get; set; }

    public virtual AguaHidrometro? Hidro { get; set; }

    public virtual ProdRurPropriedade? IdpropriedadeNavigation { get; set; }
}

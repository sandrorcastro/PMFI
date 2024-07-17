using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicTecnicaOpco
{
    public int IdOpcao { get; set; }

    public int? IdTecnica { get; set; }

    public string? DsOpcao { get; set; }

    public decimal? NrPontuacaoPadrao { get; set; }

    public virtual TbLicTecnica? IdTecnicaNavigation { get; set; }

    public virtual ICollection<TbLicParticipanteTecnica> TbLicParticipanteTecnicas { get; set; } = new List<TbLicParticipanteTecnica>();
}

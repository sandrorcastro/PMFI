using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicParticipanteTecnica
    {
        public int IdParticipante { get; set; }
        public int IdTecnica { get; set; }
        public int IdOpcao { get; set; }
        public decimal? NrPontuacao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbLicTecnicaOpco IdOpcaoNavigation { get; set; } = null!;
        public virtual TbLicParticipante IdParticipanteNavigation { get; set; } = null!;
        public virtual TbLicTecnica IdTecnicaNavigation { get; set; } = null!;
    }
}

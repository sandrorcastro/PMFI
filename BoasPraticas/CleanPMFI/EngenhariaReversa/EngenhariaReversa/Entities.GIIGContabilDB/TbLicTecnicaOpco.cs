using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicTecnicaOpco
    {
        public TbLicTecnicaOpco()
        {
            TbLicParticipanteTecnicas = new HashSet<TbLicParticipanteTecnica>();
        }

        public int IdOpcao { get; set; }
        public int? IdTecnica { get; set; }
        public string? DsOpcao { get; set; }
        public decimal? NrPontuacaoPadrao { get; set; }

        public virtual TbLicTecnica? IdTecnicaNavigation { get; set; }
        public virtual ICollection<TbLicParticipanteTecnica> TbLicParticipanteTecnicas { get; set; }
    }
}

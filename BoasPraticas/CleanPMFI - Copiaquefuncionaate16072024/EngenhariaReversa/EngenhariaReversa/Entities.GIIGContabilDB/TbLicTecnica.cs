using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicTecnica
    {
        public TbLicTecnica()
        {
            TbLicLicitacaoTecnicas = new HashSet<TbLicLicitacaoTecnica>();
            TbLicParticipanteTecnicas = new HashSet<TbLicParticipanteTecnica>();
            TbLicTecnicaOpcos = new HashSet<TbLicTecnicaOpco>();
        }

        public int IdTecnica { get; set; }
        public short? IdEmpresa { get; set; }
        public string? DsTecnica { get; set; }
        public string? FlMultiplaEscolha { get; set; }

        public virtual ICollection<TbLicLicitacaoTecnica> TbLicLicitacaoTecnicas { get; set; }
        public virtual ICollection<TbLicParticipanteTecnica> TbLicParticipanteTecnicas { get; set; }
        public virtual ICollection<TbLicTecnicaOpco> TbLicTecnicaOpcos { get; set; }
    }
}

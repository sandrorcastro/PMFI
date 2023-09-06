using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicTiposSituacoesParticipante
    {
        public TbLicTiposSituacoesParticipante()
        {
            TbLicParticipantesSituacaos = new HashSet<TbLicParticipantesSituacao>();
        }

        public short IdTipoSituacaoParticipante { get; set; }
        public string? DsTipoSituacaoParticipante { get; set; }

        public virtual ICollection<TbLicParticipantesSituacao> TbLicParticipantesSituacaos { get; set; }
    }
}

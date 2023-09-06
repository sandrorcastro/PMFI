using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicParticipantesSituacao
    {
        public int IdParticipanteSituacao { get; set; }
        public int IdParticipante { get; set; }
        public short IdTipoSituacaoParticipante { get; set; }
        public DateTime? DtSituacao { get; set; }
        public string? DsObservacoes { get; set; }

        public virtual TbLicParticipante IdParticipanteNavigation { get; set; } = null!;
        public virtual TbLicTiposSituacoesParticipante IdTipoSituacaoParticipanteNavigation { get; set; } = null!;
    }
}

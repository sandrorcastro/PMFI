using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicParticipantesLotesCotacao
    {
        public int IdParticipante { get; set; }
        public int NrLote { get; set; }
        public decimal? VlCotacao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbLicParticipante IdParticipanteNavigation { get; set; } = null!;
    }
}

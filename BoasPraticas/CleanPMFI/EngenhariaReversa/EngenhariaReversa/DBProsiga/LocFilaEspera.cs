using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class LocFilaEspera
    {
        public long FilaEsperaId { get; set; }
        public int? FespTaxaId { get; set; }
        public DateTime? FespDataIni { get; set; }
        public DateTime? FespDataFim { get; set; }
        public string? FespHorarioIni { get; set; }
        public string? FespHorarioFim { get; set; }
        public long? FespContribId { get; set; }
        public int? FespAtividade { get; set; }
        /// <summary>
        /// Atendido ou branco
        /// </summary>
        public string? FespSituacao { get; set; }
        public string? FespTecUltAlt { get; set; }
        public DateTime? FespDtUltAlt { get; set; }

        public virtual LocAtividade? FespAtividadeNavigation { get; set; }
        public virtual Contribuinte? FespContrib { get; set; }
    }
}

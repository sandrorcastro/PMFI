using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribZonaTipoLiberacao
    {
        public TribZonaTipoLiberacao()
        {
            Tbconsultapreviazoneamentoresposta = new HashSet<Tbconsultapreviazoneamentoresposta>();
            TbtribZonaZoneamentoAtividadePergunta = new HashSet<TbtribZonaZoneamentoAtividadePergunta>();
            TribZonaUsoAtividades = new HashSet<TribZonaUsoAtividade>();
            TribZonaZoneamentoAtividades = new HashSet<TribZonaZoneamentoAtividade>();
            TribZonaZoneamentoUsos = new HashSet<TribZonaZoneamentoUso>();
        }

        public short ZotlId { get; set; }
        public string? ZotlNome { get; set; }

        public virtual ICollection<Tbconsultapreviazoneamentoresposta> Tbconsultapreviazoneamentoresposta { get; set; }
        public virtual ICollection<TbtribZonaZoneamentoAtividadePergunta> TbtribZonaZoneamentoAtividadePergunta { get; set; }
        public virtual ICollection<TribZonaUsoAtividade> TribZonaUsoAtividades { get; set; }
        public virtual ICollection<TribZonaZoneamentoAtividade> TribZonaZoneamentoAtividades { get; set; }
        public virtual ICollection<TribZonaZoneamentoUso> TribZonaZoneamentoUsos { get; set; }
    }
}

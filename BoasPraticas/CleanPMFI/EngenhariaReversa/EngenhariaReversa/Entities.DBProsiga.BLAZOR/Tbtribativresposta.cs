using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Tbtribativresposta
    {
        public Tbtribativresposta()
        {
            Tbconsultapreviadocumentoresposta = new HashSet<Tbconsultapreviadocumentoresposta>();
            Tbconsultapreviagrauriscoresposta = new HashSet<Tbconsultapreviagrauriscoresposta>();
            Tbconsultapreviazoneamentoresposta = new HashSet<Tbconsultapreviazoneamentoresposta>();
            TbtribZonaZoneamentoAtividadePergunta = new HashSet<TbtribZonaZoneamentoAtividadePergunta>();
            TribAtivAtividadeGrauRiscoPergunta = new HashSet<TribAtivAtividadeGrauRiscoPergunta>();
            TribAtivAtividadePergunta = new HashSet<TribAtivAtividadePergunta>();
        }

        public int Idresposta { get; set; }
        public string? Dsresposta { get; set; }

        public virtual ICollection<Tbconsultapreviadocumentoresposta> Tbconsultapreviadocumentoresposta { get; set; }
        public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; }
        public virtual ICollection<Tbconsultapreviazoneamentoresposta> Tbconsultapreviazoneamentoresposta { get; set; }
        public virtual ICollection<TbtribZonaZoneamentoAtividadePergunta> TbtribZonaZoneamentoAtividadePergunta { get; set; }
        public virtual ICollection<TribAtivAtividadeGrauRiscoPergunta> TribAtivAtividadeGrauRiscoPergunta { get; set; }
        public virtual ICollection<TribAtivAtividadePergunta> TribAtivAtividadePergunta { get; set; }
    }
}

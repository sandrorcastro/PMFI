using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribZonaTipoLiberacao
{
    public short ZotlId { get; set; }

    public string? ZotlNome { get; set; }

    public virtual ICollection<Tbconsultapreviazoneamentoresposta> Tbconsultapreviazoneamentoresposta { get; set; } = new List<Tbconsultapreviazoneamentoresposta>();

    public virtual ICollection<TbtribZonaZoneamentoAtividadePergunta> TbtribZonaZoneamentoAtividadePergunta { get; set; } = new List<TbtribZonaZoneamentoAtividadePergunta>();

    public virtual ICollection<TribZonaUsoAtividade> TribZonaUsoAtividades { get; set; } = new List<TribZonaUsoAtividade>();

    public virtual ICollection<TribZonaZoneamentoAtividade> TribZonaZoneamentoAtividades { get; set; } = new List<TribZonaZoneamentoAtividade>();

    public virtual ICollection<TribZonaZoneamentoUso> TribZonaZoneamentoUsos { get; set; } = new List<TribZonaZoneamentoUso>();
}

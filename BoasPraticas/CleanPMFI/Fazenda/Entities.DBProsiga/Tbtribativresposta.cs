using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbtribativresposta
{
    public int Idresposta { get; set; }

    public string? Dsresposta { get; set; }

    public virtual ICollection<Tbconsultapreviadocumentoresposta> Tbconsultapreviadocumentoresposta { get; set; } = new List<Tbconsultapreviadocumentoresposta>();

    public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; } = new List<Tbconsultapreviagrauriscoresposta>();

    public virtual ICollection<Tbconsultapreviazoneamentoresposta> Tbconsultapreviazoneamentoresposta { get; set; } = new List<Tbconsultapreviazoneamentoresposta>();

    public virtual ICollection<TbtribZonaZoneamentoAtividadePergunta> TbtribZonaZoneamentoAtividadePergunta { get; set; } = new List<TbtribZonaZoneamentoAtividadePergunta>();

    public virtual ICollection<TribAtivAtividadeGrauRiscoPergunta> TribAtivAtividadeGrauRiscoPergunta { get; set; } = new List<TribAtivAtividadeGrauRiscoPergunta>();

    public virtual ICollection<TribAtivAtividadePergunta> TribAtivAtividadePergunta { get; set; } = new List<TribAtivAtividadePergunta>();
}

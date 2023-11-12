using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbtribgraurisco
{
    public int Idrisco { get; set; }

    public string? Dsrisco { get; set; }

    public int? Nrprioridade { get; set; }

    public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; } = new List<Tbconsultapreviagrauriscoresposta>();

    public virtual ICollection<Tbconsultapreviagraurisco> Tbconsultapreviagrauriscos { get; set; } = new List<Tbconsultapreviagraurisco>();

    public virtual ICollection<TribAtivAtividadeGrauRiscoPergunta> TribAtivAtividadeGrauRiscoPergunta { get; set; } = new List<TribAtivAtividadeGrauRiscoPergunta>();

    public virtual ICollection<TribAtivAtividadeGrauRisco> TribAtivAtividadeGrauRiscos { get; set; } = new List<TribAtivAtividadeGrauRisco>();
}

using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class HabOpcaoMoradium
{
    public int OpcaoMoradiaId { get; set; }

    public int? AtendimentoId { get; set; }

    public int? IdRegiao { get; set; }

    public byte? OpcaoMoradia { get; set; }

    public virtual HabAtendimento? Atendimento { get; set; }

    public virtual Regio? IdRegiaoNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbObrIntervencao
{
    public int Idintervencao { get; set; }

    public short IdtipoObraServ { get; set; }

    public string NmObra { get; set; } = null!;

    public string DsObjetoObra { get; set; } = null!;

    public decimal NrMedidaObra { get; set; }

    public int UnMedId { get; set; }

    public decimal VlEstimado { get; set; }

    public DateTime DtRefEstimado { get; set; }

    public virtual TbObrTipoObrasServico IdtipoObraServNavigation { get; set; } = null!;

    public virtual AlmUnMed UnMed { get; set; } = null!;
}

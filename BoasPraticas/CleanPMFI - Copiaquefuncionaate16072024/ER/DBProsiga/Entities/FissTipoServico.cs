using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissTipoServico
{
    public long ServTpId { get; set; }

    public string? ServTpDescricao { get; set; }

    public string? ServTpAltCadEmpresa { get; set; }

    public string? ServTpGeraProtocolo { get; set; }

    public int? TipoProId { get; set; }

    public int? DivId { get; set; }

    public virtual ICollection<FissServicoTipoServico> FissServicoTipoServicos { get; set; } = new List<FissServicoTipoServico>();

    public virtual ICollection<FissTipoServicoTributo> FissTipoServicoTributos { get; set; } = new List<FissTipoServicoTributo>();
}

using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaUnidadesMedidum
{
    public short IdUnidadeMedida { get; set; }

    public string? DsUnidadeMedida { get; set; }

    public short? IdUnidadeMedidaPadrao { get; set; }

    public short? NrAnoLimite { get; set; }

    public virtual TbPlaUnidadesMedidasPadrao? IdUnidadeMedidaPadraoNavigation { get; set; }

    public virtual ICollection<TbCapConvAuxPrograma> TbCapConvAuxProgramas { get; set; } = new List<TbCapConvAuxPrograma>();

    public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; } = new List<TbPlaIndicadoresMovimento>();

    public virtual ICollection<TbPlaIndicadoresSimplificado> TbPlaIndicadoresSimplificados { get; set; } = new List<TbPlaIndicadoresSimplificado>();

    public virtual ICollection<TbPlaObjetivosMetasLocalizadore> TbPlaObjetivosMetasLocalizadores { get; set; } = new List<TbPlaObjetivosMetasLocalizadore>();
}

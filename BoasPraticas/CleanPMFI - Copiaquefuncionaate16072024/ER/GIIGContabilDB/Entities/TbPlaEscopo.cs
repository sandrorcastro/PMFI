using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaEscopo
{
    public short IdEscopo { get; set; }

    public short IdEmpresa { get; set; }

    public short IdTipoEscopo { get; set; }

    public short? NrAnoElaboracao { get; set; }

    public short? NrAnoInicial { get; set; }

    public short? NrAnoFinal { get; set; }

    public string? DsEscopo { get; set; }

    public virtual TbPlaTiposEscopo IdTipoEscopoNavigation { get; set; } = null!;

    public virtual ICollection<TbPlaIndicadore> TbPlaIndicadores { get; set; } = new List<TbPlaIndicadore>();

    public virtual ICollection<TbPlaVerso> TbPlaVersos { get; set; } = new List<TbPlaVerso>();
}

using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbParNumeracaoObjeto
{
    public int IdNumeracao { get; set; }

    public string? NmObjeto { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public int? NrObjeto { get; set; }
}

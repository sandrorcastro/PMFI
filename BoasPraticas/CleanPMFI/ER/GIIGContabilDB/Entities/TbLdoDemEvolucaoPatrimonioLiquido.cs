using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoDemEvolucaoPatrimonioLiquido
{
    public int IdPatrimonio { get; set; }

    public int? IdEmpresa { get; set; }

    public short? NrAnoLdo { get; set; }

    public short? NrAnoReferencia { get; set; }

    public decimal? VlPatrimonioCapital { get; set; }

    public decimal? VlReservas { get; set; }

    public decimal? VlResultAcumulado { get; set; }

    public decimal? VlPatrimonioRegPrev { get; set; }

    public decimal? VlReservasRegPrev { get; set; }

    public decimal? VlResultAcumuladoRegPrev { get; set; }
}

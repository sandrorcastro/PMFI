using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaEixo
{
    public int IdEixo { get; set; }

    public string? CdEixo { get; set; }

    public string? DsEixo { get; set; }

    public short? IdUnidadeMedida { get; set; }

    public string? DsMedida { get; set; }

    public DateTime? DtBase { get; set; }

    public string? DsIndiceFinal { get; set; }

    public int? IdEscopo { get; set; }

    public short? IdVersaoCriacao { get; set; }
}

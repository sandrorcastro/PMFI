using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbTempHodometroHorimetro
{
    public int? IdPessoa { get; set; }

    public int? CdBem { get; set; }

    public int? NrSequencialHodoHori { get; set; }

    public string? NrMes { get; set; }

    public short? NrAno { get; set; }

    public string? IdTipoMedidor { get; set; }

    public string? NrMedicaoInicial { get; set; }

    public string? NrMedicaoFinal { get; set; }

    public string? NrMedicaoDeclarada { get; set; }

    public string? DsNotaExplicativa { get; set; }

    public string Flag { get; set; } = null!;
}

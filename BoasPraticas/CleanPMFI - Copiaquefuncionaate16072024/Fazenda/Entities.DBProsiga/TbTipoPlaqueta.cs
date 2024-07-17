using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbTipoPlaqueta
{
    public int IdTipoPlaqueta { get; set; }

    public string DsTipoPlaqueta { get; set; } = null!;

    public string CRecurso { get; set; } = null!;

    public short NrColunas { get; set; }

    public string MgSuperior { get; set; } = null!;

    public string MgInferior { get; set; } = null!;

    public string MgEsquerda { get; set; } = null!;

    public string MgDireita { get; set; } = null!;

    public string? MgEntreColunas { get; set; }

    public string AlPlaqueta { get; set; } = null!;

    public string LgPlaqueta { get; set; } = null!;
}

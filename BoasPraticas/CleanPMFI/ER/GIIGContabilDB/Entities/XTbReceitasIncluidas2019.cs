using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class XTbReceitasIncluidas2019
{
    public string? CdReceita { get; set; }

    public short? NrAno { get; set; }

    public string? DsDesdobramento { get; set; }

    public string? IdTipoNivelConta { get; set; }

    public string? DsEspecificacao { get; set; }

    public string? FlReceitaIntraOrcamentaria { get; set; }

    public byte? IdTipoPermissaoDeducao { get; set; }
}

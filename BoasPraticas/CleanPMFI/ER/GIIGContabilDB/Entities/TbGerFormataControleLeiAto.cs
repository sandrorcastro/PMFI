using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerFormataControleLeiAto
{
    public string DsTipoObjeto { get; set; } = null!;

    public string NmFormulario { get; set; } = null!;

    public string? IdArray { get; set; }
}

using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmFontesXconveniosAuxilio
{
    public int IdFonteConvenio { get; set; }

    public short? IdEmpresa { get; set; }

    public string? CdConvenioAuxilio { get; set; }

    public string? CdReceitaCorrente { get; set; }

    public string? CdReceitaCapital { get; set; }

    public string? CdContabilDivFlutuante { get; set; }
}

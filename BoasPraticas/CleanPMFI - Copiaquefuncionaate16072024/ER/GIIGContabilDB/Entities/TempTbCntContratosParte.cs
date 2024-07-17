using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbCntContratosParte
{
    public int IdParteContrato { get; set; }

    public int IdContrato { get; set; }

    public int IdPessoa { get; set; }

    public short IdTipoParteContrato { get; set; }

    public decimal? VlContrato { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdPessoaRepresentante { get; set; }
}

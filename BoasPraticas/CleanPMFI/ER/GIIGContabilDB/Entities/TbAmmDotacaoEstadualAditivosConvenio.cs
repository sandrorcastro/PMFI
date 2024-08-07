﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmDotacaoEstadualAditivosConvenio
{
    public int IdAditivo { get; set; }

    public short? IdEmpresa { get; set; }

    public string? CdConvenioAuxilio { get; set; }

    public DateTime? DtAditivo { get; set; }

    public string? CdDotacao { get; set; }
}

﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribParamCoeficTaxa
{
    public long? TribParamCoeId { get; set; }

    public long? TribCoeId { get; set; }

    public long? TparamId { get; set; }

    public long? ParamId { get; set; }

    public long? TribParamCoeIdref { get; set; }
}

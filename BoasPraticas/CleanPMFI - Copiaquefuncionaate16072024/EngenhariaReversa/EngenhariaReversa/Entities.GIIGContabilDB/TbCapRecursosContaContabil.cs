﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapRecursosContaContabil
    {
        public int IdRecursoContaContabil { get; set; }
        public int IdRecurso { get; set; }
        public string CdContaContabilConsignar { get; set; } = null!;
        public DateTime? DtBaseTce { get; set; }
        public short? NrAno { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TemptribAtividadeTipoAlvaraTributo
    {
        public string Atividade { get; set; } = null!;
        public int TipoTribId { get; set; }
        public int TalvId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class EdutipoSerie
    {
        public EdutipoSerie()
        {
            Eduseries = new HashSet<Eduserie>();
        }

        public long TipoSerId { get; set; }
        public string? TipoSerNome { get; set; }

        public virtual ICollection<Eduserie> Eduseries { get; set; }
    }
}

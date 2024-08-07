﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Tbcategorium
    {
        public Tbcategorium()
        {
            Tbservicos = new HashSet<Tbservico>();
        }

        public int Idcategoria { get; set; }
        public string? Descricao { get; set; }
        public string? Nome { get; set; }

        public virtual ICollection<Tbservico> Tbservicos { get; set; }
    }
}

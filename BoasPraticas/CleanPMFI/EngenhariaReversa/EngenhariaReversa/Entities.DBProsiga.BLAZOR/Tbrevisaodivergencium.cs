﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Tbrevisaodivergencium
    {
        public Tbrevisaodivergencium()
        {
            Tribedificacoesdivergencia = new HashSet<Tribedificacoesdivergencium>();
            Tribquadradivergencia = new HashSet<Tribquadradivergencium>();
        }

        public int Iddivergencia { get; set; }
        public string Dsdivergencia { get; set; } = null!;

        public virtual ICollection<Tribedificacoesdivergencium> Tribedificacoesdivergencia { get; set; }
        public virtual ICollection<Tribquadradivergencium> Tribquadradivergencia { get; set; }
    }
}

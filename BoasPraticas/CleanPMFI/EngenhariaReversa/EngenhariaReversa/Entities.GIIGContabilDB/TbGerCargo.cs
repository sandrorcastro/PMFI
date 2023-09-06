using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerCargo
    {
        public TbGerCargo()
        {
            TbGerCargosServidores = new HashSet<TbGerCargosServidore>();
        }

        public int IdCargo { get; set; }
        public string? DsCargo { get; set; }
        public string? DsTipo { get; set; }

        public virtual ICollection<TbGerCargosServidore> TbGerCargosServidores { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SerIturObjetoAtrativosTuristico
    {
        public long ObjId { get; set; }
        public long AtrativoId { get; set; }
        public string? Descricao { get; set; }

        public virtual SerIturAtrativosTuristico Atrativo { get; set; } = null!;
        public virtual SerIturObjeto Obj { get; set; } = null!;
    }
}

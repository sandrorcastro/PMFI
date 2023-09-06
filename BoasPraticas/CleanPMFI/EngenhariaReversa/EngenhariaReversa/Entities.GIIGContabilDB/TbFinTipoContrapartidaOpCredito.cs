using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinTipoContrapartidaOpCredito
    {
        public TbFinTipoContrapartidaOpCredito()
        {
            TbFinContrapartidasOpCreditos = new HashSet<TbFinContrapartidasOpCredito>();
        }

        public int IdTipoContraPartidaOpCredito { get; set; }
        public string? DsTipoContraPartidaOpCredito { get; set; }

        public virtual ICollection<TbFinContrapartidasOpCredito> TbFinContrapartidasOpCreditos { get; set; }
    }
}

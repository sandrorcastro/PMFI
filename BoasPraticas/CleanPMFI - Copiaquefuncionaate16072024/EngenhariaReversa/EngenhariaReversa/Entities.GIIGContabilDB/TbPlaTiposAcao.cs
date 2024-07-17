using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaTiposAcao
    {
        public TbPlaTiposAcao()
        {
            TbPlaAcoesMovimentos = new HashSet<TbPlaAcoesMovimento>();
        }

        public short IdTipoAcao { get; set; }
        public string? DsTipoAcao { get; set; }
        public string? TpAcao { get; set; }
        public string? CdInicio { get; set; }

        public virtual ICollection<TbPlaAcoesMovimento> TbPlaAcoesMovimentos { get; set; }
    }
}

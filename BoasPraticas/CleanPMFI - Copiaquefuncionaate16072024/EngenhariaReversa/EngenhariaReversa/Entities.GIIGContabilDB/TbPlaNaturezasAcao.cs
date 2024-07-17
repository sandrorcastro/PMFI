using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaNaturezasAcao
    {
        public TbPlaNaturezasAcao()
        {
            TbPlaAcoesMovimentos = new HashSet<TbPlaAcoesMovimento>();
        }

        public short IdNaturezaAcao { get; set; }
        public string? DsNaturezaAcao { get; set; }

        public virtual ICollection<TbPlaAcoesMovimento> TbPlaAcoesMovimentos { get; set; }
    }
}

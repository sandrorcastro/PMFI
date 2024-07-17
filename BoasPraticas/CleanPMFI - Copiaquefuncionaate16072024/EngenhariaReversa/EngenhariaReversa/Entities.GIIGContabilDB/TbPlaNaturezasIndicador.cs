using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaNaturezasIndicador
    {
        public TbPlaNaturezasIndicador()
        {
            TbPlaIndicadoresMovimentos = new HashSet<TbPlaIndicadoresMovimento>();
        }

        public string IdNaturezaIndicador { get; set; } = null!;
        public string? DsNaturezaIndicador { get; set; }

        public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; }
    }
}

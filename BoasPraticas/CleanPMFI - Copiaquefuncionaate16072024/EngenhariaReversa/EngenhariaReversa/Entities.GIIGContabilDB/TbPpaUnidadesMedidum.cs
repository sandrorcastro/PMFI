using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPpaUnidadesMedidum
    {
        public TbPpaUnidadesMedidum()
        {
            TbPpaIndicadores = new HashSet<TbPpaIndicadore>();
            TbPpaProgramasAcos = new HashSet<TbPpaProgramasAco>();
            TbSbsSubvencaoSocials = new HashSet<TbSbsSubvencaoSocial>();
        }

        public short IdUnidadeMedida { get; set; }
        public string? DsUnidadeMedida { get; set; }

        public virtual ICollection<TbPpaIndicadore> TbPpaIndicadores { get; set; }
        public virtual ICollection<TbPpaProgramasAco> TbPpaProgramasAcos { get; set; }
        public virtual ICollection<TbSbsSubvencaoSocial> TbSbsSubvencaoSocials { get; set; }
    }
}

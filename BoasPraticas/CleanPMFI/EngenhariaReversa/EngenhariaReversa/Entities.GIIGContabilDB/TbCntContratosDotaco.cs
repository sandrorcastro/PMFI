using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntContratosDotaco
    {
        public int IdContrato { get; set; }
        public int IdDotacao { get; set; }
        public DateTime? DtVinculacao { get; set; }
        public decimal? VlPrevisto { get; set; }
        public bool? FlBloqueiaSaldo { get; set; }

        public virtual TbCntContrato IdContratoNavigation { get; set; } = null!;
        public virtual TbOrcDotaco IdDotacaoNavigation { get; set; } = null!;
    }
}

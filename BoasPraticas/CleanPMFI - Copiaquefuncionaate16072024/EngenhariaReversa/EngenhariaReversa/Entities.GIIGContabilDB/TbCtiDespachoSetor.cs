using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCtiDespachoSetor
    {
        public int IdDespacho { get; set; }
        public int IdQuestionario { get; set; }
        public int IdSetorOrigem { get; set; }
        public int IdSetorDestino { get; set; }
        public string DtDespacho { get; set; } = null!;
        public string? DsParecer { get; set; }

        public virtual TbCtiQuestionario IdQuestionarioNavigation { get; set; } = null!;
        public virtual TbCtiSetore IdSetorOrigemNavigation { get; set; } = null!;
    }
}

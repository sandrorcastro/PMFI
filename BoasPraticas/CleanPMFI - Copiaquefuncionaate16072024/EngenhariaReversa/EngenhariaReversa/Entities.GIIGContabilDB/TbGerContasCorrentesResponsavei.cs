using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerContasCorrentesResponsavei
    {
        public int IdResponsavel { get; set; }
        public int IdCc { get; set; }
        public int? IdPessoa { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtBaixa { get; set; }
        public short? IdTipoBaixa { get; set; }
        public string? DsMotivo { get; set; }

        public virtual TbGerContasCorrente IdCcNavigation { get; set; } = null!;
        public virtual TbGerTiposBaixaResponsavel? IdTipoBaixaNavigation { get; set; }
    }
}

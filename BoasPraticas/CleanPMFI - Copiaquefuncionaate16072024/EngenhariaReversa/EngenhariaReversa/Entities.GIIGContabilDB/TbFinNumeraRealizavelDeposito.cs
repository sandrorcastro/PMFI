using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinNumeraRealizavelDeposito
    {
        public int IdNumeracao { get; set; }
        public short? IdEmpresa { get; set; }
        public string? TpNumeracao { get; set; }
        public int? NrNumeracao { get; set; }
        public short? NrAnoNumeracao { get; set; }
        public DateTime? DtNumeracao { get; set; }
        public string? CdContaContabil { get; set; }
        public short? IdTipoMovimento { get; set; }
        public string? NmObjeto { get; set; }
        public int? IdObjeto { get; set; }

        public virtual TbFinTipoMovtoNumeraRealizavelDeposito? IdTipoMovimentoNavigation { get; set; }
    }
}

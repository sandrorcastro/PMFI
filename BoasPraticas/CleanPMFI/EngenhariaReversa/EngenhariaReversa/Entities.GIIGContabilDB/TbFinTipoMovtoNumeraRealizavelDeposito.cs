using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinTipoMovtoNumeraRealizavelDeposito
    {
        public TbFinTipoMovtoNumeraRealizavelDeposito()
        {
            TbFinNumeraRealizavelDepositos = new HashSet<TbFinNumeraRealizavelDeposito>();
        }

        public short IdTipoMovimento { get; set; }
        public string? DsTipoMovimento { get; set; }
        public short? CdTc { get; set; }
        public string? FlInscricao { get; set; }
        public string? TpRegistro { get; set; }

        public virtual ICollection<TbFinNumeraRealizavelDeposito> TbFinNumeraRealizavelDepositos { get; set; }
    }
}

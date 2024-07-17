using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicCotacaoItensVencedorCancelado
    {
        public int IdCancelamento { get; set; }
        public int IdCotacao { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public decimal? NrQuantidade { get; set; }
        public decimal? VlCancelado { get; set; }
        public string? DsMotivo { get; set; }
        public int? IdCotacaoRepassado { get; set; }

        public virtual TbLicCotacaoIten IdCotacaoNavigation { get; set; } = null!;
    }
}

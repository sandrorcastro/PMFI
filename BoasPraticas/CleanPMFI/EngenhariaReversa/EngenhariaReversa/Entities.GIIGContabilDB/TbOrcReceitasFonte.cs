using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcReceitasFonte
    {
        public int IdReceita { get; set; }
        public int IdFonte { get; set; }
        public string? CdContaContabilDisponivel { get; set; }
        public decimal? VlPercentual { get; set; }
        public string? FlDesabilitarTransferencia { get; set; }
        public string? FlUsaOrcamento { get; set; }

        public virtual TbOrcFonte IdFonteNavigation { get; set; } = null!;
        public virtual TbOrcReceita IdReceitaNavigation { get; set; } = null!;
    }
}

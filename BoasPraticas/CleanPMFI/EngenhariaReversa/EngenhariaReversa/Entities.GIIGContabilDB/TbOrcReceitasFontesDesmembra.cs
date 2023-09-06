using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcReceitasFontesDesmembra
    {
        public int IdReceitaFonteDesmembra { get; set; }
        public int? IdReceitaFonte { get; set; }
        public int? IdFonte { get; set; }
        public string? CdContaContabilDisponivel { get; set; }
        public decimal? VlPercentual { get; set; }
        public string? FlDesabilitarTransferencia { get; set; }
        public string? FlUsaOrcamento { get; set; }

        public virtual TbOrcReceitasFontesOperacao? IdReceitaFonteNavigation { get; set; }
    }
}

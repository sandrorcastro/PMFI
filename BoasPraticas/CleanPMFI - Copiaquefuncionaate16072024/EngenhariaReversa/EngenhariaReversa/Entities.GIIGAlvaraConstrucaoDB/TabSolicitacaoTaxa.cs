using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGAlvaraConstrucaoDB
{
    public partial class TabSolicitacaoTaxa
    {
        public int SoliId { get; set; }
        public string TipoTribNome { get; set; } = null!;
        public string SotaDataPgto { get; set; } = null!;
        public decimal SotaValorPago { get; set; }
        public string SotaSituacao { get; set; } = null!;
        public int ImoIdDivida { get; set; }

        public virtual TabSolicitaco Soli { get; set; } = null!;
    }
}

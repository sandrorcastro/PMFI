using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGAlvaraConstrucaoDB
{
    public partial class TabSolicitacaoAtividade
    {
        public int SolaId { get; set; }
        public int SoliId { get; set; }
        public string SolaCnae { get; set; } = null!;
        public string SolaDescricao { get; set; } = null!;
        public string SolaSiglaZoneamento { get; set; } = null!;

        public virtual TabSolicitaco Soli { get; set; } = null!;
    }
}

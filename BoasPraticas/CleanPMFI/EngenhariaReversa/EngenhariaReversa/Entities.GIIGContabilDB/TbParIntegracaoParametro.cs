using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbParIntegracaoParametro
    {
        public int IdIntegracaoParam { get; set; }
        public short IdTipoIntegracao { get; set; }
        public string? NmParametro { get; set; }
        public string? DsParametro { get; set; }
        public string? NmVariavel { get; set; }
        public string? VlVariavel { get; set; }
        public string? VlParametro { get; set; }
        public short? NrSequenciaChecagem { get; set; }
        public string? CdHistorico { get; set; }

        public virtual TbParTiposIntegracao IdTipoIntegracaoNavigation { get; set; } = null!;
    }
}

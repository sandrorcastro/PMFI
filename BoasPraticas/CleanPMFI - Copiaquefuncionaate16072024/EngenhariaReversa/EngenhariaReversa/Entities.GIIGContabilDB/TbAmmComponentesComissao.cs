using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbAmmComponentesComissao
    {
        public int IdComponente { get; set; }
        public int? IdEmpresa { get; set; }
        public string? NrDocumentoMembro { get; set; }
        public string? NmCredor { get; set; }
        public string? CdAtribuicao { get; set; }
        public int? NrAtoNomeacao { get; set; }
        public short? NrAnoAtoNomeacao { get; set; }
        public DateTime? DtPubAtoNomeacao { get; set; }
        public int? NrAtoDesligamento { get; set; }
        public short? NrAnoAtoDesligamento { get; set; }
        public DateTime? DtPubAtoDesligamento { get; set; }
    }
}

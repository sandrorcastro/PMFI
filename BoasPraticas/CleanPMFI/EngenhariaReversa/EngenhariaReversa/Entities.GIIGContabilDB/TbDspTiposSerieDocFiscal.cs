using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspTiposSerieDocFiscal
    {
        public TbDspTiposSerieDocFiscal()
        {
            TbDspDocumentosFiscais = new HashSet<TbDspDocumentosFiscai>();
            TbDspLiquidacoesDocumentos = new HashSet<TbDspLiquidacoesDocumento>();
        }

        public short IdTipoSerieDocFiscal { get; set; }
        public string? DsTipoSerieDocFiscal { get; set; }
        public short? CdTc { get; set; }
        public short? IdSerieFiss { get; set; }
        public bool? FlAtivo { get; set; }

        public virtual ICollection<TbDspDocumentosFiscai> TbDspDocumentosFiscais { get; set; }
        public virtual ICollection<TbDspLiquidacoesDocumento> TbDspLiquidacoesDocumentos { get; set; }
    }
}

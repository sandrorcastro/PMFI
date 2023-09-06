using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspCodigosFiscaisOperacoesPrestaco
    {
        public TbDspCodigosFiscaisOperacoesPrestaco()
        {
            TbDspLiquidacoesDocumentos = new HashSet<TbDspLiquidacoesDocumento>();
        }

        public int CdCfop { get; set; }
        public string? DsCfop { get; set; }

        public virtual ICollection<TbDspLiquidacoesDocumento> TbDspLiquidacoesDocumentos { get; set; }
    }
}

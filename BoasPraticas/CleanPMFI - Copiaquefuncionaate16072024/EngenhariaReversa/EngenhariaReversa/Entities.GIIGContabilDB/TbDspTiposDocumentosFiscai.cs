using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspTiposDocumentosFiscai
    {
        public TbDspTiposDocumentosFiscai()
        {
            TbDspDocumentosFiscais = new HashSet<TbDspDocumentosFiscai>();
            TbDspLiquidacoesDocumentos = new HashSet<TbDspLiquidacoesDocumento>();
            TbSbsPrestacaoConta = new HashSet<TbSbsPrestacaoConta>();
        }

        public int IdTipoDoctoFiscal { get; set; }
        public string? NmTipoDoctoFiscal { get; set; }
        public string? FlControlaVencimento { get; set; }
        public short? CdTipoTc { get; set; }
        public short? NrDiasPadrao { get; set; }
        public bool? FlAtivo { get; set; }
        public short? NrDigitosCodigoBarras { get; set; }
        public bool? FlUsaSerie { get; set; }
        public string? FlConvenio { get; set; }

        public virtual ICollection<TbDspDocumentosFiscai> TbDspDocumentosFiscais { get; set; }
        public virtual ICollection<TbDspLiquidacoesDocumento> TbDspLiquidacoesDocumentos { get; set; }
        public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; }
    }
}

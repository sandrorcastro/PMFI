using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabArquivo
    {
        public int ArquId { get; set; }
        public DateTime? ArquDataArq { get; set; }
        public string? ArquLocal { get; set; }
        /// <summary>
        /// Contem a situação do arquivamento &apos;N&apos; Normal e &apos;C&apos; Cancelado
        /// </summary>
        public string? ArquStatus { get; set; }
        public long? ProcId { get; set; }
        public short? FuncId { get; set; }
        public DateTime? ArquDataDes { get; set; }
        public string? ArquDespacho { get; set; }
        public string? ArquSala { get; set; }
        public string? ArquBloco { get; set; }
        public string? ArquCorredor { get; set; }
        public string? ArquCaixa { get; set; }
        public string? ArquTipoArquivo { get; set; }
        public DateTime? ArquPrazoGuarda { get; set; }
        public string? ArquFormatoDocumentoAnexo { get; set; }
        public byte[]? ArquDocumentoAnexo { get; set; }
        public string? ArquDocumentoAnexoData { get; set; }

        public virtual TabFuncionario? Func { get; set; }
        public virtual TabProcesso? Proc { get; set; }
    }
}

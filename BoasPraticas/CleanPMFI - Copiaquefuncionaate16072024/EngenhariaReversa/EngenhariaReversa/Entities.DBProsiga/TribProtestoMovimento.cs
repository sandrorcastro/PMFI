using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribProtestoMovimento
    {
        public int IdMovimento { get; set; }
        public int? IdLote { get; set; }
        public long? CertidaoDaid { get; set; }
        public DateTime? DtOcorrencia { get; set; }
        public string? FlSituacao { get; set; }
        public string? DsObservacao { get; set; }
        public string? DsNomeArquivoRetorno { get; set; }
        public string? DsNomeArquivo { get; set; }
        public short? IdIrregularidade { get; set; }
        public string? IdOcorrencia { get; set; }
        public string? DtProtocolo { get; set; }
        public string? DsProtocolo { get; set; }
        public int? IdCartorio { get; set; }
    }
}

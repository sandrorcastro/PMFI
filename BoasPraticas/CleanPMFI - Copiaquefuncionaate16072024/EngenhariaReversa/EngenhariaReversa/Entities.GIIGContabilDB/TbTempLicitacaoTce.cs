using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbTempLicitacaoTce
    {
        public int? NrLicitacao { get; set; }
        public short? NrAno { get; set; }
        public short? IdModalidade { get; set; }
        public short? IdSituacao { get; set; }
        public DateTime? DtOcorrencia { get; set; }
        public string? DsMotivo { get; set; }
        public int? IdPessoa { get; set; }
        public string? DsTipo { get; set; }
        public string? NrTce { get; set; }
        public string? NrAnoTce { get; set; }
        public string? IdModalidadeTce { get; set; }
        public string? CdImportacao { get; set; }
        public string? FlAtiva { get; set; }
    }
}

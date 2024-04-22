using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TmpLogsistema
    {
        public string? Contribuinte { get; set; }
        public long LogId { get; set; }
        public string? CnpjCpfInscricao { get; set; }
        public int? Ano { get; set; }
        public int? Tributo { get; set; }
        public int? SubDivida { get; set; }
        public string? LoSiTipoOcorrencia { get; set; }
        public string? LoSiOcorrencia { get; set; }
        public string? LoSiUsuario { get; set; }
        public string? LoSiHost { get; set; }
        public DateTime? LoSiData { get; set; }
    }
}

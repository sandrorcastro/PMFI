using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class VisaoComprovanteProcesso
    {
        public long ProcId { get; set; }
        public DateTime? ProcDataEntrada { get; set; }
        public string? ProcPublicaWeb { get; set; }
        public int? ProcTipoProcId { get; set; }
        public long? ProcIdContribuinte { get; set; }
        public string? ProcDescricao { get; set; }
        public string? ConCnpjcpf { get; set; }
        public string? ConNome { get; set; }
        public string? TipoProNome { get; set; }
    }
}

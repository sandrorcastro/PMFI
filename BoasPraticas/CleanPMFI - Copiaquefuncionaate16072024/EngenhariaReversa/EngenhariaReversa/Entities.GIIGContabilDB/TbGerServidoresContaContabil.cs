using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerServidoresContaContabil
    {
        public int IdServidorContaContabil { get; set; }
        public int? IdServidor { get; set; }
        public string? CdContaContabil { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public string? DsHistorico { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginInclusao { get; set; }
        public DateTime? DtAlteracao { get; set; }
        public string? DsLoginAlteracao { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabContribuintePermissao
    {
        public short ContPermId { get; set; }
        public string? ConsInscricao { get; set; }
        public string? SubCid { get; set; }
        public string? ConsPermissao { get; set; }
        public short? IdTipoContribuinte { get; set; }
        public int? ProcNumero { get; set; }
        public int? ProcAno { get; set; }
        public string? Motivo { get; set; }
        public string? Usuario { get; set; }
        public DateTime? DataHora { get; set; }

        public virtual TabTipoContribuinte? IdTipoContribuinteNavigation { get; set; }
    }
}

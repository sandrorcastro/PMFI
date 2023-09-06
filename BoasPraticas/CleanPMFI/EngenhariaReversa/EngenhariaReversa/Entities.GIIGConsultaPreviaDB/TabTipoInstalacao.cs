using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabTipoInstalacao
    {
        public int? IdTipoInstalacao { get; set; }
        public string? NmTipoInstalacao { get; set; }
        public string? FlCampoAdicional { get; set; }
        public string? DsLabelCampoAdicional { get; set; }
        public string? FlTipoCampo { get; set; }
        public string? VlCampo { get; set; }
    }
}

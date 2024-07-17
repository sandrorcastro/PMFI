using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicClausula
    {
        public short IdClausula { get; set; }
        public short? IdModelo { get; set; }
        public string? NmClausula { get; set; }
        public string? DsClausula { get; set; }
        public int? NrOrdem { get; set; }
        public string? FlExibiTitulo { get; set; }
        public string? FlExibiLinhasTitulo { get; set; }

        public virtual TbLicModelosDocto? IdModeloNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerContaCorrenteGp
    {
        public int? IdCc { get; set; }
        public short? IdEmpresa { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public short? NrAno { get; set; }
        public string? DsTipoEmpresa { get; set; }
    }
}

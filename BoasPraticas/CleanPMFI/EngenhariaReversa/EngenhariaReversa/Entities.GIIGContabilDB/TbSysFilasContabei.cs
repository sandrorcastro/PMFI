using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSysFilasContabei
    {
        public string CdObjeto { get; set; } = null!;
        public long IdObjeto { get; set; }
        public short? IdEmpresa { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public DateTime? DtObjeto { get; set; }
        public DateTime? DtProcesso { get; set; }
        public string? DsErro { get; set; }
        public string? DsLogin { get; set; }
        public string? NrEnderecoIp { get; set; }

        public virtual TbSysObjetosContabei CdObjetoNavigation { get; set; } = null!;
    }
}

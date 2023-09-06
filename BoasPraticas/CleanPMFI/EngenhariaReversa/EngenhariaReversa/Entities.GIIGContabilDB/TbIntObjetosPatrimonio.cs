using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbIntObjetosPatrimonio
    {
        public string NmObjeto { get; set; } = null!;
        public int IdObjeto { get; set; }
        public DateTime? DtIntegracao { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
    }
}

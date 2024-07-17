using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAtivSetorLicenciamentousuario
    {
        public int Idusuario { get; set; }
        public short SetorId { get; set; }
        public DateTime Dtinclusao { get; set; }
        public int Idusuarioinclusao { get; set; }
    }
}

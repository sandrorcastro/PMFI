using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRelControlesSaldo
    {
        public short IdEmpresa { get; set; }
        public short NrAno { get; set; }
        public short NrMes { get; set; }
        public string TpSaldo { get; set; } = null!;
        public bool? FlAtualizado { get; set; }
    }
}

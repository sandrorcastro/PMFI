using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbTrbEditaisContribMelhorium
    {
        public int IdEdital { get; set; }
        public short? NrExercicio { get; set; }
        public byte? NrBimestre { get; set; }
        public int? NrEdital { get; set; }
        public DateTime? DtEdital { get; set; }
        public string? DsObjeto { get; set; }
    }
}

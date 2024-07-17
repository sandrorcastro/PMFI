using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntContratosAbertura
    {
        public int IdContratoAbertura { get; set; }
        public int IdContrato { get; set; }
        public short NrExercicio { get; set; }
        public short? NrMes { get; set; }
    }
}

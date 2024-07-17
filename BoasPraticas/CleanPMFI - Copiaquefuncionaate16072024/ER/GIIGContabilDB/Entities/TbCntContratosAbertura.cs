using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntContratosAbertura
{
    public int IdContratoAbertura { get; set; }

    public int IdContrato { get; set; }

    public short NrExercicio { get; set; }

    public short? NrMes { get; set; }
}

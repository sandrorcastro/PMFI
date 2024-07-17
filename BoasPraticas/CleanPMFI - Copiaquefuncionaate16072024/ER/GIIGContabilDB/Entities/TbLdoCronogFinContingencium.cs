using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoCronogFinContingencium
{
    public int IdCronogFinReserva { get; set; }

    public int? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public short? NrBimestreLrf { get; set; }

    public decimal? VlReservaContingencia { get; set; }
}

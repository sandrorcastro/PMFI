﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinTipoMovtoNumeraRealizavelDeposito
{
    public short IdTipoMovimento { get; set; }

    public string? DsTipoMovimento { get; set; }

    public short? CdTc { get; set; }

    public string? FlInscricao { get; set; }

    public string? TpRegistro { get; set; }

    public virtual ICollection<TbFinNumeraRealizavelDeposito> TbFinNumeraRealizavelDepositos { get; set; } = new List<TbFinNumeraRealizavelDeposito>();
}

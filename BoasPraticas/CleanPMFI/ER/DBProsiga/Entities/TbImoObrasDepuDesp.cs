﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbImoObrasDepuDesp
{
    public int IdobrasDepuDesp { get; set; }

    public int ImoTbImoObrasIdObra { get; set; }

    public int NroDepuDespNum { get; set; }

    public short NroDepuDespAno { get; set; }

    public string DsDePuTipoDespesa { get; set; } = null!;

    public decimal? VlDepuDespValor { get; set; }

    public virtual TbImoObra ImoTbImoObrasIdObraNavigation { get; set; } = null!;
}

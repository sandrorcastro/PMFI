using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerCidade
{
    public int Idcidade { get; set; }

    public string? NmCidade { get; set; }

    public string? DsUf { get; set; }

    public int? Idpais { get; set; }

    public int? CdIbge { get; set; }

    public virtual TbGerPaise? IdpaisNavigation { get; set; }

    public virtual ICollection<TbDspDiaria> TbDspDiaria { get; set; } = new List<TbDspDiaria>();

    public virtual ICollection<TbGerAgencia> TbGerAgencia { get; set; } = new List<TbGerAgencia>();

    public virtual ICollection<TbGerEndereco> TbGerEnderecos { get; set; } = new List<TbGerEndereco>();
}

using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerTiposBaixaResponsavel
{
    public short IdTipoBaixa { get; set; }

    public string? DsTipoBaixa { get; set; }

    public virtual ICollection<TbGerContasCorrentesResponsavei> TbGerContasCorrentesResponsaveis { get; set; } = new List<TbGerContasCorrentesResponsavei>();
}

using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicTiposComissao
{
    public short IdTipoComissao { get; set; }

    public string? NmTipoComissao { get; set; }

    public virtual ICollection<TbLicAtosNomeacaoComissao> TbLicAtosNomeacaoComissaos { get; set; } = new List<TbLicAtosNomeacaoComissao>();
}

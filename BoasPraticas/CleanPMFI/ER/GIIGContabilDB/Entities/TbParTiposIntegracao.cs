using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbParTiposIntegracao
{
    public short IdTipoIntegracao { get; set; }

    public short? IdEmpresa { get; set; }

    public string? NmTipoIntegracao { get; set; }

    public string? DsSigla { get; set; }

    public DateTime? DtAtivacao { get; set; }

    public DateTime? DtInativacao { get; set; }

    public virtual ICollection<TbParIntegracaoParametro> TbParIntegracaoParametros { get; set; } = new List<TbParIntegracaoParametro>();

    public virtual ICollection<TbParIntegracoesContabei> TbParIntegracoesContabeis { get; set; } = new List<TbParIntegracoesContabei>();
}

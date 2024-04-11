using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspLiquidacaoComunicacao
{
    public int IdComunicacao { get; set; }

    public int? IdLiquidacaoDocto { get; set; }

    public int? IdPessoa { get; set; }

    public string? DsTipoComunicacao { get; set; }

    public decimal? VlComunicacao { get; set; }

    public virtual TbDspLiquidacoesDocumento? IdLiquidacaoDoctoNavigation { get; set; }
}

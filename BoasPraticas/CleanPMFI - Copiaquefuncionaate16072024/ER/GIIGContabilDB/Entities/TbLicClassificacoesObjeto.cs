using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicClassificacoesObjeto
{
    public short IdClassificacaoObjeto { get; set; }

    public string? DsClassificacaoObjeto { get; set; }

    public string? FlPadraoTce { get; set; }

    public string? DsSigla { get; set; }

    public string? FlUsaEmpenho { get; set; }

    public short? CdTc { get; set; }

    public bool? FlAtivo { get; set; }

    public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; } = new List<TbDspEmpenho>();

    public virtual ICollection<TbDspIten> TbDspItens { get; set; } = new List<TbDspIten>();

    public virtual ICollection<TbLicLimite> TbLicLimites { get; set; } = new List<TbLicLimite>();

    public virtual ICollection<TbLicRegimesExecuco> IdRegimeExecucaos { get; set; } = new List<TbLicRegimesExecuco>();
}

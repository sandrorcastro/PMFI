using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerCondicoesPagamento
{
    public short IdCondicaoPgto { get; set; }

    public string? DsCondicaoPgto { get; set; }

    public short? CdTc { get; set; }

    public bool? FlAtivo { get; set; }

    public virtual ICollection<TbCntContrato> TbCntContratos { get; set; } = new List<TbCntContrato>();

    public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; } = new List<TbDspEmpenho>();

    public virtual ICollection<TbDspSolicitacoesEmpenho> TbDspSolicitacoesEmpenhos { get; set; } = new List<TbDspSolicitacoesEmpenho>();

    public virtual ICollection<TbLicCotacaoIten> TbLicCotacaoItens { get; set; } = new List<TbLicCotacaoIten>();

    public virtual ICollection<TbLicLicitacoesIten> TbLicLicitacoesItens { get; set; } = new List<TbLicLicitacoesIten>();

    public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; } = new List<TbLicLicitaco>();
}

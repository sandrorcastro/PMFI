using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerPrazosEntrega
{
    public short IdPrazoEntrega { get; set; }

    public string? DsPrazoEntrega { get; set; }

    public short? NrDias { get; set; }

    public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; } = new List<TbDspEmpenho>();

    public virtual ICollection<TbDspSolicitacoesEmpenho> TbDspSolicitacoesEmpenhos { get; set; } = new List<TbDspSolicitacoesEmpenho>();

    public virtual ICollection<TbLicCotacaoIten> TbLicCotacaoItens { get; set; } = new List<TbLicCotacaoIten>();

    public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; } = new List<TbLicLicitaco>();
}

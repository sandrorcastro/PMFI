using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinArquivoRetornoDetalhe
{
    public int IdIntegracaoDetalhe { get; set; }

    public int? IdIntegracao { get; set; }

    public int? IdOrdemCreditoDetalhe { get; set; }

    public int? IdOrdemPagamento { get; set; }

    public string? DsRemetente { get; set; }

    public string? DsDestinatario { get; set; }

    public string? DsFuncional { get; set; }

    public string? DsPagamento { get; set; }

    public DateTime? DtDetalhe { get; set; }

    public decimal? VlDetalhe { get; set; }

    public string? CdRetorno { get; set; }

    public string? DsRetorno { get; set; }

    public string? FlSituacao { get; set; }

    public string? NrAutenticacao { get; set; }
}

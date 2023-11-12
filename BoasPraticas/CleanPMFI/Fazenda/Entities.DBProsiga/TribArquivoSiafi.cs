using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribArquivoSiafi
{
    public int IdDetalhe { get; set; }

    public string? TpSiafi { get; set; }

    public string? NmArquivo { get; set; }

    public short? NrSequencia { get; set; }

    public string? NrCnpjtomador { get; set; }

    public DateTime? DtDocumento { get; set; }

    public string? NrDocumento { get; set; }

    public string? NrCpfcnpjprestador { get; set; }

    public string? NrCompetencia { get; set; }

    public string? NrNotaFiscal { get; set; }

    public DateTime? DtVencimento { get; set; }

    public string? NrSerie { get; set; }

    public DateTime? DtEmissaoNota { get; set; }

    public decimal? VlNotaFiscal { get; set; }

    public decimal? VlAliquota { get; set; }

    public decimal? VlPrincipal { get; set; }

    public decimal? VlMulta { get; set; }

    public decimal? VlJuros { get; set; }

    public decimal? VlBaseCalculo { get; set; }

    public string? DsObservacao { get; set; }

    public long? EmprIddivida { get; set; }

    public long? ConIddivida { get; set; }

    public int? ConvenioId { get; set; }

    public DateTime? DtBaixa { get; set; }

    public DateTime? DataEstorno { get; set; }

    public string? MotivoEstorno { get; set; }

    public string? UsuarioEstorno { get; set; }
}

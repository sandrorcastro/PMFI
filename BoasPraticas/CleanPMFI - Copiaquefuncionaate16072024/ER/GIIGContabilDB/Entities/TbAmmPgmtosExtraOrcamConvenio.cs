using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmPgmtosExtraOrcamConvenio
{
    public int IdPagamentoExtraCap { get; set; }

    public short? NrMes { get; set; }

    public short? IdEmpresa { get; set; }

    public int? CdConvenioAuxilio { get; set; }

    public short? NrAno { get; set; }

    public int? IdContrato { get; set; }

    public int? CdModalidadeLicitacao { get; set; }

    public short? NrAnoLicitacao { get; set; }

    public int? NrLicitacao { get; set; }

    public short? CdDocFiscal { get; set; }

    public string? NrComprovante { get; set; }

    public DateTime? DtDocFiscal { get; set; }

    public short? TpDocPagamento { get; set; }

    public string? NrDocPagamento { get; set; }

    public DateTime? DtPagamento { get; set; }

    public decimal? VlPago { get; set; }

    public string? TpDocumento { get; set; }

    public string? NrDocumento { get; set; }

    public string? NrInscricaoEstadual { get; set; }

    public string? NrInscricaoMunicipal { get; set; }

    public string? NmCredor { get; set; }

    public string? DsHistorico { get; set; }

    public short? TpEspecie { get; set; }
}

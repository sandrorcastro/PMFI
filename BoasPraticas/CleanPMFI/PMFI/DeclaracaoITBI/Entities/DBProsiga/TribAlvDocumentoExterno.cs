using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAlvDocumentoExterno
{
    public int IdDocumento { get; set; }

    public string? CdDocumento { get; set; }

    public int? ConIdRequerente { get; set; }

    public string? DsTipoDocumento { get; set; }

    public short? NrProcessoAno { get; set; }

    public int? NrProcessoSequencia { get; set; }

    public string? NrInscricao { get; set; }

    public string? DsTipoResponsavel { get; set; }

    public string? CepObra { get; set; }

    public string? DsObraFone { get; set; }

    public string? DsObraEmail { get; set; }

    public string? NrPropCpfcnpj { get; set; }

    public string? NmProprietario { get; set; }

    public string? CepProprietario { get; set; }

    public string? DsPropEndereco { get; set; }

    public string? DsObraEndereco { get; set; }

    public string? NrRespCpfcnpj { get; set; }

    public string? NmResponsavel { get; set; }

    public int? ConIdExecucao { get; set; }

    public int? ConIdProjeto { get; set; }

    public string? NrCreaExecucao { get; set; }

    public string? NrCreaProjeto { get; set; }

    public string? DsObra { get; set; }

    public string? NrQuadra { get; set; }

    public string? NrLote { get; set; }

    public int? NrUnidades { get; set; }

    public int? NrPavimentos { get; set; }

    public DateOnly? DtInicioObra { get; set; }

    public decimal? NrAreaTerreno { get; set; }

    public decimal? VlTotalAreaConstrucao { get; set; }

    public decimal? VlVenalTerreno { get; set; }

    public string? DsAreaConstrucao { get; set; }

    public string? RefAnterior { get; set; }

    public string? DsObservacao { get; set; }

    public DateTime? DtRegistro { get; set; }

    public DateTime? DtUltimaAlteracao { get; set; }

    public string? FlSituacao { get; set; }

    public int? IdAlvaraInterno { get; set; }

    public string? DsTipoDocOrigem { get; set; }

    public int? NrNumOrigem { get; set; }

    public int? NrAnoOrigem { get; set; }

    public string? DsMotivoRecusa { get; set; }
}

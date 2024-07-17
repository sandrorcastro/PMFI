using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribAlvDocumentoLog
    {
        public int IdLog { get; set; }
        public int IdDocumento { get; set; }
        public long? NrCmcExecucao { get; set; }
        public long? NrCmcProjeto { get; set; }
        public string? DsObraEndereco { get; set; }
        public string? DsObra { get; set; }
        public string? NrCreaExecucao { get; set; }
        public string? NrCreaProjeto { get; set; }
        public string? NmProprietario { get; set; }
        public string? NrPropCpfcnpj { get; set; }
        public string? DsPropFone { get; set; }
        public string? DsPropEndereco { get; set; }
        public string? DsArea { get; set; }
        public string? NrInscricao { get; set; }
        public string? NrLote { get; set; }
        public string? NrQuadra { get; set; }
        public string? DsObservacao { get; set; }
        public string? DsAvaliacaoIssqn { get; set; }
        public decimal? NrAreaTerreno { get; set; }
        public string? CepObra { get; set; }
        public string? CepProprietario { get; set; }
        public decimal? VlTotalAreaConstrucao { get; set; }
        public DateTime? DtLog { get; set; }
        public string? DsUsuario { get; set; }
        public string? DsMotivo { get; set; }
    }
}

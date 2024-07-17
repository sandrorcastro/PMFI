using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribAlvDocumento
    {
        public TribAlvDocumento()
        {
            TribAlvCalculos = new HashSet<TribAlvCalculo>();
            TribAlvDivida = new HashSet<TribAlvDividum>();
            TribAlvDocumentoAreaConstrucaos = new HashSet<TribAlvDocumentoAreaConstrucao>();
            TribSisObraLoteAlvaraAlvDocumentos = new HashSet<TribSisObraLoteAlvaraAlvDocumento>();
        }

        public int IdDocumento { get; set; }
        public short? NrAno { get; set; }
        public int? NrSequencia { get; set; }
        public long? NrCmcExecucao { get; set; }
        public long? NrCmcProjeto { get; set; }
        public string? DsObraEndereco { get; set; }
        public string? DsObra { get; set; }
        public string? NrArt { get; set; }
        public string? NrCreaExecucao { get; set; }
        public string? NrCreaProjeto { get; set; }
        public string? NmProprietario { get; set; }
        public string? NrPropCpfcnpj { get; set; }
        public string? DsPropFone { get; set; }
        public string? DsPropEndereco { get; set; }
        public string? DsArea { get; set; }
        public string? NrInscricao { get; set; }
        public DateTime? DtDocumento { get; set; }
        public string? NrNossoNumero { get; set; }
        public string? FlComValor { get; set; }
        public int? NrProtocolo { get; set; }
        public string? NrLote { get; set; }
        public string? NrQuadra { get; set; }
        public string? DsObservacao { get; set; }
        public string? DsAvaliacaoIssqn { get; set; }
        public byte[]? ImDocumento { get; set; }
        public string? DsTipoDocumento { get; set; }
        public string? DsTitulo { get; set; }
        public string? DsTexto { get; set; }
        public int? IdDocumentoOrigem { get; set; }
        public decimal? NrAreaTerreno { get; set; }
        public int? NrSequenciaOrigem { get; set; }
        public short? NrAnoOrigem { get; set; }
        public string? Dispensado { get; set; }
        public string? CepObra { get; set; }
        public string? CepProprietario { get; set; }
        public decimal? VlTotalAreaConstrucao { get; set; }
        public string? FlOutorga { get; set; }
        public decimal? VlVenalTerreno { get; set; }
        public decimal? VlAreaInfracionadaTerreno { get; set; }
        public decimal? VlTaxaOutorga { get; set; }
        public string? DsInscricaoEstatual { get; set; }
        public string? Situacao { get; set; }
        public string? DsMotivoCancelamento { get; set; }
        public string? RefAnterior { get; set; }
        public string? DsDescAreaConstrucao { get; set; }
        public DateTime? DtExclusaoAlvara { get; set; }
        public string? DsUsuarioExclusao { get; set; }
        public int? IdCpfcnpjExecucao { get; set; }
        public int? IdCpfcnpjProjeto { get; set; }
        public short? NrProcessoAno { get; set; }
        public int? NrProcessoSequencia { get; set; }
        public string? DsUsuarioInclusao { get; set; }
        public string? FlTipoAlvara { get; set; }
        public string? TpRespObraProjeto { get; set; }
        public string? TpRespObraExecucao { get; set; }

        public virtual ICollection<TribAlvCalculo> TribAlvCalculos { get; set; }
        public virtual ICollection<TribAlvDividum> TribAlvDivida { get; set; }
        public virtual ICollection<TribAlvDocumentoAreaConstrucao> TribAlvDocumentoAreaConstrucaos { get; set; }
        public virtual ICollection<TribSisObraLoteAlvaraAlvDocumento> TribSisObraLoteAlvaraAlvDocumentos { get; set; }
    }
}

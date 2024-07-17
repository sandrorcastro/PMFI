using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class CadastroContribuinte
    {
        public int IdEmpresa { get; set; }
        public int? IdContribuinte { get; set; }
        public string? Situacao { get; set; }
        public string? Crc { get; set; }
        public byte IdRegime { get; set; }
        public string SubTributacao { get; set; } = null!;
        public string? Tributacao { get; set; }
        public int? IdEmpresaMatriz { get; set; }
        public DateTime? DtAberturaEmpresa { get; set; }
        public string? NumeroProcessoAbertura { get; set; }
        public string? CpfCnpjContador { get; set; }
        public string? EnderecoContador { get; set; }
        public string? TelefoneContador { get; set; }
        public string? NomeContador { get; set; }
        public DateTime? Dtadesaosubstituto { get; set; }
        public string? NomeContribuinte { get; set; }
        public string? CpfCnpjContribuinte { get; set; }
        public string TipoContribuinte { get; set; } = null!;
        public int? IdCidade { get; set; }
        public string? RuaContribuinte { get; set; }
        public string? CepContribuinte { get; set; }
        public string? NumeroContribuinte { get; set; }
        public string? ComplementoContribuinte { get; set; }
        public string? BairroContribuinte { get; set; }
        public string? ImContribuinte { get; set; }
        public string? EmailContribuinte { get; set; }
        public string? TelefoneContribuinte { get; set; }
        public string? SituacaoContribuinte { get; set; }
        public string? EndCorrespondenciaContribuinte { get; set; }
        public string? NumCorrespondenciaContribuinte { get; set; }
        public string? NumFaxContribuinte { get; set; }
        public string? SiteContribuinte { get; set; }
        public DateTime? DataCadastroContribuinte { get; set; }
        public int? CidadeCorrespondenciaContribuinte { get; set; }
        public string? ComplementoCorrespondenciaContribuinte { get; set; }
        public string? BairroCorrespondenciaContribuinte { get; set; }
        public string? CepCorrespondenciaContribuinte { get; set; }
    }
}

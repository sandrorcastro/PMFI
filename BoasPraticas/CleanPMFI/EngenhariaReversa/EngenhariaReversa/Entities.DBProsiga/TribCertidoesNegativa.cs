using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribCertidoesNegativa
    {
        public long CertNegId { get; set; }
        public DateTime? CertNegDataEmissao { get; set; }
        public DateTime? CertNegValidaAte { get; set; }
        public long? EdificacaoId { get; set; }
        public string? CertNegCnpjcpf { get; set; }
        /// <summary>
        /// informar se é de Imovel, Pessoa Juridica  ou Pessoa Fisica
        /// </summary>
        public string? CertNegDe { get; set; }
        public string? CertNegUsuario { get; set; }
        /// <summary>
        /// Informar se é positiva, negativa ou positiva com efeito negativo
        /// </summary>
        public string? CertNegTitulo { get; set; }
        /// <summary>
        /// Neste campo será gravado o nome do contriuinte do imóvel, pessoa física ou jurídica.
        /// </summary>
        public string? CertNegNome { get; set; }
        /// <summary>
        /// Nome do responsável pelo imóvel para impressão da certidão por inscrição.
        /// </summary>
        public string? CertNegNomeResp { get; set; }
        /// <summary>
        /// Numero da inscrição imobiliária do imóvel.
        /// </summary>
        public string? CertNegInscricao { get; set; }
        /// <summary>
        /// Colocar o nome do logradouro já com seu tipo (RUA, AV. TVA e etc.).
        /// </summary>
        public string? CertNegLogradouro { get; set; }
        /// <summary>
        /// Número predial do endereço do imovel no caso de certidão por inscrição. Nos casos de certidão pessoa fisica ou juridica, colocar o endereço do contribuinte.
        /// </summary>
        public string? CertNegNumPredial { get; set; }
        /// <summary>
        /// Nome do bairro do endereço.
        /// </summary>
        public string? CertNegBairro { get; set; }
        /// <summary>
        /// Complemento do endereço.
        /// </summary>
        public string? CertNegComplemento { get; set; }
        /// <summary>
        /// Nome da cidade do endereço.
        /// </summary>
        public string? CertNegCidade { get; set; }
        /// <summary>
        /// Sigla da UF - Unidade Federativa do endereço.
        /// </summary>
        public string? CertNegUf { get; set; }
        /// <summary>
        /// Número do CMC do contribuinte no caso de pessoa juridica ou física.
        /// </summary>
        public long? CertNegCmc { get; set; }
        public string? CertNegOrigem { get; set; }
        public string? CertNegDenominacaoPredial { get; set; }
        public string? CertNegRequerente { get; set; }
        public decimal? CertNegAreaTerreno { get; set; }
        public decimal? CertNegAreaConstruida { get; set; }
        public decimal? CertNegValorVenal { get; set; }
        public decimal? CertNegAreaCoberta { get; set; }
        public string? CertNegRefAnterior { get; set; }
        public string? CertNegFinalidade { get; set; }
        public string? CertNegTexto { get; set; }
        public string? CertNegPagina { get; set; }
        public string? CertNegInstrNormativa { get; set; }
        public string? CertNegTipoCertidao { get; set; }
        /// <summary>
        /// Observações sobre a certidão negativa.
        /// </summary>
        public string? CertNegObs { get; set; }
        public string? CertNegAtivPrincCmc { get; set; }
        public string? CertNegAtivPrincCmcdenom { get; set; }
        /// <summary>
        /// Marca se a certidão foi emitida de maneira forçada.
        /// </summary>
        public string? CertNegForcada { get; set; }
        /// <summary>
        /// Grava a Situação da empresa
        /// </summary>
        public string? CertNegSituacao { get; set; }
        public decimal? CertNegCoeficiente { get; set; }
        public string? CertNegMatricula { get; set; }
        public decimal? CertNegAreaUsoComum { get; set; }
        public string? CertNegPossuiDividaContribMelhoria { get; set; }
        public string? TribCertidoesNegativas { get; set; }
        public decimal? CertNegAreaTerrNaoTributada { get; set; }
        public decimal? CertNegAreaConstruidaUnid { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribParametro
    {
        public string TparamId { get; set; } = null!;
        /// <summary>
        /// Informar o convenio da conta que é utilizada para recebimento dos boletos
        /// </summary>
        public int? ConvenioId { get; set; }
        /// <summary>
        /// Validade padrão de certidões negativa de débito (em dias).
        /// </summary>
        public long CertnegValidade { get; set; }
        /// <summary>
        /// Marca dagua da certidao negativa de debitos municipais.
        /// </summary>
        public byte[]? CertnegMarcaDagua { get; set; }
        /// <summary>
        /// Titulo da certidao negativa de debitos. (SECRETARIA MUNICIPAL DA FAZENDA).
        /// </summary>
        public string CertnegTitulo { get; set; } = null!;
        /// <summary>
        /// SubTitulo da certidao negativa de debitos. (DEPARTAMENTO DE RECEITA).
        /// </summary>
        public string CertnegSubTitulo { get; set; } = null!;
        /// <summary>
        /// Fone para contato em caso de erro na emissão de certidão.
        /// </summary>
        public string CertnegFoneContato { get; set; } = null!;
        /// <summary>
        /// Email para contato em caso de erro na tentativa de emissão de certidão.
        /// </summary>
        public string CertnegEmailContato { get; set; } = null!;
        /// <summary>
        /// Email disparado automáticamente nos casos de erro na emissão de certidão via internet. (Caso de duplicidade no cadastro).
        /// </summary>
        public string CertnegEmailToAutomatico { get; set; } = null!;
        /// <summary>
        /// Email usado para envio de mensagem automatica.
        /// </summary>
        public string CertnegEmailFromAutomatico { get; set; } = null!;
        /// <summary>
        /// Nome do servidor SMTP
        /// </summary>
        public string CertnegServidorSmtp { get; set; } = null!;
        /// <summary>
        /// Endereço da internet para emissão e autenticidade da certidão.
        /// </summary>
        public string CertnegPagina { get; set; } = null!;
        /// <summary>
        /// Texto com o número da Instrução Normativa que aprova a certidão.
        /// </summary>
        public string CertnegInstrNormativa { get; set; } = null!;
        public long? TextoIdcertNegativaImovel { get; set; }
        public long? TextoIdcertNegativaFisica { get; set; }
        public long? TextoIdcertNegativaJuridica { get; set; }
        public long? TextoIdcertPositivaEnimovel { get; set; }
        public long? TextoIdcertPositivaEnfisica { get; set; }
        public long? TextoIdcertPositivaEnjuridica { get; set; }
        public long? TextoIdcertPositivaImovel { get; set; }
        public long? TextoIdcertPositivaFisica { get; set; }
        public long? TextoIdcertPositivaJuridica { get; set; }
        public int? TipoTribIditbi { get; set; }
        public decimal? PercPadItbiimovelNaoFinanc { get; set; }
        /// <summary>
        /// Quantidades de dias a partir da data de geracao do itbi para seu vencimento
        /// </summary>
        public int? DiasVencimentoItbi { get; set; }
        public int? TipoTribIss { get; set; }
        public int? TipoTribIssretidoFonte { get; set; }
        /// <summary>
        /// Link para fornecedor baixar o edital que comprou.
        /// </summary>
        public string? UrlDownloadEdital { get; set; }
        public string? NomeResponsavel { get; set; }
        public string? CargoResponsavel { get; set; }
        public string? NomeDivisao { get; set; }
        public byte[]? AssinaturaDigitalizada { get; set; }
        public byte[]? CarimboContratoCorreio { get; set; }
        /// <summary>
        /// Texto do tipo observação utilizado na guia de ocupação e uso do solo.
        /// </summary>
        public long? TextoIdobsGuia { get; set; }
        public byte[]? SenhaSupervisor { get; set; }
        public DateTime? DtExpSenhaSupervisor { get; set; }

        public virtual ConvenioBanco? Convenio { get; set; }
    }
}

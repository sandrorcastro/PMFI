using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribSnarquivoDetalhe
    {
        public TribSnarquivoDetalhe()
        {
            TribSndivida = new HashSet<TribSndivida>();
        }

        /// <summary>
        /// Código de identificação de cada linha de divida contida no arquivo.
        /// </summary>
        public int SnarqDetId { get; set; }
        /// <summary>
        /// Código de identificação do arquivo de dividas do Simples Nacional.
        /// </summary>
        public int? SnarqId { get; set; }
        /// <summary>
        /// Código de unidade de jurisdição do devedor principal na RFB.
        /// </summary>
        public string? SnarqDetUaprinc { get; set; }
        /// <summary>
        /// Nome empresarial do devedor principal.
        /// </summary>
        public string? SnarqDetRazaoPrinc { get; set; }
        /// <summary>
        /// Número de identificação do devedor principal.
        /// </summary>
        public string? SnarqDetCnpjprinc { get; set; }
        /// <summary>
        /// Código da Classificação Nacional de Atividades Econômicas do devedor principal.
        /// </summary>
        public string? SnarqDetCnaeprinc { get; set; }
        /// <summary>
        /// Data da falência do devedor principal.
        /// </summary>
        public DateTime? SnarqDetDataFalenciaPrinc { get; set; }
        /// <summary>
        /// Tipo de logradouro do endereço do devedor principal.
        /// </summary>
        public string? SnarqDetTipoLogradPrinc { get; set; }
        /// <summary>
        /// Logradouro do endereço do devedor principal.
        /// </summary>
        public string? SnarqDetLogradouroPrinc { get; set; }
        /// <summary>
        /// Número do endereço do devedor principal.
        /// </summary>
        public string? SnarqDetNumeroPrinc { get; set; }
        /// <summary>
        /// Complemente do endereço do devedor principal.
        /// </summary>
        public string? SnarqDetComplementoPrinc { get; set; }
        /// <summary>
        /// Bairro do endereço do devedor principal.
        /// </summary>
        public string? SnarqDetBairroPrinc { get; set; }
        /// <summary>
        /// Código do município do endereço do devedor principal.
        /// </summary>
        public string? SnarqDetCodMunicipioPrinc { get; set; }
        /// <summary>
        /// Nome do município do endereço do devedor principal.
        /// </summary>
        public string? SnarqDetMunicipioPrinc { get; set; }
        /// <summary>
        /// Sigla da unidade federativa do endereço do devedor principal.
        /// </summary>
        public string? SnarqDetUfprinc { get; set; }
        /// <summary>
        /// Código de endereçamento postal do devedor principal.
        /// </summary>
        public int? SnarqDetCepprinc { get; set; }
        /// <summary>
        /// Código de unidade de jurisdição do devedor original na RFB.
        /// </summary>
        public int? SnarqDetUaorig { get; set; }
        /// <summary>
        /// Nome empresarial do devedor.
        /// </summary>
        public string? SnarqDetRazaoOrig { get; set; }
        /// <summary>
        /// Número de identificação do devedor original.
        /// </summary>
        public string? SnarqDetCnpjorig { get; set; }
        /// <summary>
        /// Código da Classificação Nacional de Atividades Econômicas do devedor original.
        /// </summary>
        public string? SnarqDetCnaeorig { get; set; }
        /// <summary>
        /// Data da falência do devedor original.
        /// </summary>
        public DateTime? SnarqDetDaraFalenciaOrig { get; set; }
        /// <summary>
        /// Tipo de logradouro do endereço do devedor original.
        /// </summary>
        public string? SnarqDetTipoLogradOrig { get; set; }
        /// <summary>
        /// Logradouro do endereço do devedor original.
        /// </summary>
        public string? SnarqDetLogradouroOrig { get; set; }
        /// <summary>
        /// Número do endereço do devedor original.
        /// </summary>
        public string? SnarqDetNumeroOrig { get; set; }
        /// <summary>
        /// Complemente do endereço do devedor original.
        /// </summary>
        public string? SnarqDetComplementoOrig { get; set; }
        /// <summary>
        /// Bairro do endereço do devedor original.
        /// </summary>
        public string? SnarqDetBairroOrig { get; set; }
        /// <summary>
        /// Código do município do endereço do devedor original.
        /// </summary>
        public string? SnarqDetCodMunicipioOrig { get; set; }
        /// <summary>
        /// Nome do município do endereço do devedor original.
        /// </summary>
        public string? SnarqDetMunicipioOrig { get; set; }
        /// <summary>
        /// Sigla da unidade federativa do endereço do devedor original.
        /// </summary>
        public string? SnarqDetUforig { get; set; }
        /// <summary>
        /// Código de endereçamento postal do devedor original.
        /// </summary>
        public int? SnarqDetCeporig { get; set; }
        /// <summary>
        /// Sigla do tributo. Domínio: 01 - ISS, 02 - ICMS.
        /// </summary>
        public short? SnarqDetTributo { get; set; }
        /// <summary>
        /// Tipo de lançamento do débito. Domínio: 01 - Declarado, 02 - Ofício.
        /// </summary>
        public short? SnarqDetLancamento { get; set; }
        /// <summary>
        /// Tipo de natureza do débito. Domínio: 01 - Principal, 02 - Multa Vinculada.
        /// </summary>
        public short? SnarqDetNatureza { get; set; }
        /// <summary>
        /// Data de vencimento do débito.
        /// </summary>
        public DateTime? SnarqDetVencimento { get; set; }
        /// <summary>
        /// Sigla da unidade de medida de valor do débito.
        /// </summary>
        public string? SnarqDetUmv { get; set; }
        /// <summary>
        /// Valor originário do débito.
        /// </summary>
        public decimal? SnarqDetValor { get; set; }
        /// <summary>
        /// Data de início do período de apuração do débito.
        /// </summary>
        public DateTime? SnarqDetDataApuracao { get; set; }
        /// <summary>
        /// Número da declaração que lançou o débito.
        /// </summary>
        public string? SnarqDetDeclaracao { get; set; }
        /// <summary>
        /// Data da entrega da declaração que lançou o débito.
        /// </summary>
        public DateTime? SnarqDetDataEntrega { get; set; }
        /// <summary>
        /// Número do processo administrativo do débito.
        /// </summary>
        public string? SnarqDetProcesso { get; set; }
        /// <summary>
        /// Número do auto de infração que lançou o débito.
        /// </summary>
        public int? SnarqDetAutoInfracao { get; set; }
        /// <summary>
        /// Data da ciência do lançamento do auto de infração.
        /// </summary>
        public DateTime? SnarqDetDataCienciaLanc { get; set; }
        /// <summary>
        /// Data da ciência da última decisão que serviu como constituição definitiva do débito.
        /// </summary>
        public DateTime? SnarqDetDataCienciaDescisao { get; set; }
        /// <summary>
        /// Texto da fundamentação legal do principal do débito.
        /// </summary>
        public string? SnarqDetFundamentacaoPrinc { get; set; }
        /// <summary>
        /// Texto da fundamentação legal dos acréscimos legais.
        /// </summary>
        public string? SnarqDetFundamentacaoAcesc { get; set; }
        /// <summary>
        /// Percentual de multa de mora a ser aplicado no débito (Sempre 20%).
        /// </summary>
        public int? SnarqDetMultaMora { get; set; }
        /// <summary>
        /// Indica se ja foi realizado a importação das dívidas desse registro.
        /// </summary>
        public string? Snprocessado { get; set; }

        public virtual TribSnarquivo? Snarq { get; set; }
        public virtual ICollection<TribSndivida> TribSndivida { get; set; }
    }
}

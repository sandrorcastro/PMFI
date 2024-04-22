using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTipoTributo
    {
        public TribTipoTributo()
        {
            AguaCategoriaTributos = new HashSet<AguaCategoriaTributo>();
            FissServicoTributos = new HashSet<FissServicoTributo>();
            FissTipoServicoTributos = new HashSet<FissTipoServicoTributo>();
            FissTributosDespachosEmpresas = new HashSet<FissTributosDespachosEmpresa>();
            SimamtributosEquivalencia = new HashSet<SimamtributosEquivalencium>();
            TribAlvCalculos = new HashSet<TribAlvCalculo>();
            TribAlvTipoCalculos = new HashSet<TribAlvTipoCalculo>();
            TribAtivSetorTributos = new HashSet<TribAtivSetorTributo>();
            TribAtivTributosEmpresas = new HashSet<TribAtivTributosEmpresa>();
            TribAtividadeTipoAlvaraTributos = new HashSet<TribAtividadeTipoAlvaraTributo>();
            TribBaixaDevolucaoDividasComps = new HashSet<TribBaixaDevolucaoDividasComp>();
            TribClassificaReceita = new HashSet<TribClassificaReceitum>();
            TribCmtipoConstrucaos = new HashSet<TribCmtipoConstrucao>();
            TribCoeficienteTaxasIptus = new HashSet<TribCoeficienteTaxasIptu>();
            TribComposicaoDivContribuintes = new HashSet<TribComposicaoDivContribuinte>();
            TribComposicaoDivEmpresas = new HashSet<TribComposicaoDivEmpresa>();
            TribComposicaoDivImos = new HashSet<TribComposicaoDivImo>();
            TribDividasEmpresas = new HashSet<TribDividasEmpresa>();
            TribDividasImoEditals = new HashSet<TribDividasImoEdital>();
            TribDividasImos = new HashSet<TribDividasImo>();
            TribEdificacoesIsencaoTribs = new HashSet<TribEdificacoesIsencaoTrib>();
            TribEmpresasLimitesTaxas = new HashSet<TribEmpresasLimitesTaxa>();
            TribEmpresasTipoAlvaraTributos = new HashSet<TribEmpresasTipoAlvaraTributo>();
            TribEmpresasTributos = new HashSet<TribEmpresasTributo>();
            TribFiscItensVistoriaTributos = new HashSet<TribFiscItensVistoriaTributo>();
            TribIsencaoIncidencia = new HashSet<TribIsencaoIncidencium>();
            TribIssqnestimados = new HashSet<TribIssqnestimado>();
            TribItbiedifs = new HashSet<TribItbiedif>();
            TribLeisDescTributos = new HashSet<TribLeisDescTributo>();
            TribLeisDescs = new HashSet<TribLeisDesc>();
            TribQuadraLogradTributos = new HashSet<TribQuadraLogradTributo>();
            TribSimuladosEmpresaDivs = new HashSet<TribSimuladosEmpresaDiv>();
            TribTapMapas = new HashSet<TribTapMapa>();
            TribTipoProcessoTributos = new HashSet<TribTipoProcessoTributo>();
            TribTipoTributosTipoProcessos = new HashSet<TribTipoTributosTipoProcesso>();
            TribTipoTributosVencs = new HashSet<TribTipoTributosVenc>();
            TribUtilizTributos = new HashSet<TribUtilizTributo>();
            Secaos = new HashSet<TribSecao>();
            TipoIses = new HashSet<TribTipoIsencao>();
            Usus = new HashSet<Usuario>();
        }

        public int TipoTribId { get; set; }
        public string? TipoTribNome { get; set; }
        public decimal? TipoTribVlrUfm { get; set; }
        public string? TipoTribContaPrinc { get; set; }
        public string? TipoTribContaJuro { get; set; }
        public string? TipoTribContaCorr { get; set; }
        public string? TipoTribContaMulta { get; set; }
        public string? TipoTribContaPrincDa { get; set; }
        public string? TipoTribContaJuroDa { get; set; }
        public string? TipoTribContaCorrDa { get; set; }
        public string? TipoTribContaMultaDa { get; set; }
        public string? TipoTribFormulaCalculo { get; set; }
        /// <summary>
        /// Incidencia do tributo de acordo com a caracteristica do terreno
        /// </summary>
        public string TipoTribIncidencia { get; set; } = null!;
        /// <summary>
        /// Se for sim grava a incidencia em todas as quadras/logradouros o tributo
        /// </summary>
        public string TipoTribPadraoImoveis { get; set; } = null!;
        /// <summary>
        /// Informa se o tributo compoe o valor base da bonificacao
        /// </summary>
        public string TipoTribIncideBonificacao { get; set; } = null!;
        /// <summary>
        /// Informa se o tributo faz parte do IPTU
        /// </summary>
        public string TipoTribAgrupaIptu { get; set; } = null!;
        /// <summary>
        /// Valor mínimo em UFM de cada parcela do Tributo.
        /// </summary>
        public decimal TipoTribVlrUfmminParcela { get; set; }
        /// <summary>
        /// Informa se incide desconto quando for parcela unica na tabela de vencimentos.
        /// </summary>
        public string TipoTribIncideDescPagUnica { get; set; } = null!;
        /// <summary>
        /// Informa se o tributo vai ser calculado individualmente por estar englobado em outra unidade imobiliaria
        /// </summary>
        public string TipoTribCalcParaEdificacoesEnglobadas { get; set; } = null!;
        /// <summary>
        /// Pode Ser: Bonificações, Coleta de Lixo, IPTU, Limpeza Pública, Iluminação Publica, Serviço de Bombeiros, Taxas Diversas
        /// </summary>
        public string TipoTribAgrupaCalculo { get; set; } = null!;
        /// <summary>
        /// Siga do Tributo (NÃO REMOVA) - FELA
        /// </summary>
        public string? TipoTribSiglaTributo { get; set; }
        /// <summary>
        /// Forma como sera classificado o tributo, se for proporcional o valor sera repartido entre os demais tributos.
        /// </summary>
        public string TipoTribClassifProporcional { get; set; } = null!;
        /// <summary>
        /// Diferenciar os codigos de impostos e taxas. pode ser: &quot;Imposto&quot; ou &quot;Taxa&quot;.
        /// </summary>
        public string? TipoTribTipo { get; set; }
        /// <summary>
        /// Identifica se o tributo Aceita isencao por requerimento
        /// </summary>
        public string TipoTribAceitaIsencaoRequerimento { get; set; } = null!;
        /// <summary>
        /// Quando a divida é especifica e naum deva ser agrupada na DAM - ex .ITBI
        /// </summary>
        public string? TipoTribEspecifico { get; set; }
        public short? TipoTribDiasAvencer { get; set; }
        public string? TipoTribIncideMultaDa { get; set; }
        /// <summary>
        /// Marca se o tributo é utilizado para inscrição em divida ativa.
        /// </summary>
        public string TipoTribInscreveDa { get; set; } = null!;
        /// <summary>
        /// Código do convênio para cobrança do tributo através de boleto bancário.
        /// </summary>
        public int? ConvenioId { get; set; }
        public int? TrGrId { get; set; }
        public short? TrOrId { get; set; }
        /// <summary>
        /// Informa se o tributo pertence as dividas de alvara (para poder emitir alvara sem olhar as dividas de ISS)
        /// </summary>
        public string TipoTribPertenceAlvara { get; set; } = null!;
        public string? TipoTribFormaCorrecao { get; set; }
        public int? IdTipoBxDesativar { get; set; }

        public virtual ConvenioBanco? Convenio { get; set; }
        public virtual TribTipoTributosGrupo? TrGr { get; set; }
        public virtual TribTipoTributoOrigem? TrOr { get; set; }
        public virtual ICollection<AguaCategoriaTributo> AguaCategoriaTributos { get; set; }
        public virtual ICollection<FissServicoTributo> FissServicoTributos { get; set; }
        public virtual ICollection<FissTipoServicoTributo> FissTipoServicoTributos { get; set; }
        public virtual ICollection<FissTributosDespachosEmpresa> FissTributosDespachosEmpresas { get; set; }
        public virtual ICollection<SimamtributosEquivalencium> SimamtributosEquivalencia { get; set; }
        public virtual ICollection<TribAlvCalculo> TribAlvCalculos { get; set; }
        public virtual ICollection<TribAlvTipoCalculo> TribAlvTipoCalculos { get; set; }
        public virtual ICollection<TribAtivSetorTributo> TribAtivSetorTributos { get; set; }
        public virtual ICollection<TribAtivTributosEmpresa> TribAtivTributosEmpresas { get; set; }
        public virtual ICollection<TribAtividadeTipoAlvaraTributo> TribAtividadeTipoAlvaraTributos { get; set; }
        public virtual ICollection<TribBaixaDevolucaoDividasComp> TribBaixaDevolucaoDividasComps { get; set; }
        public virtual ICollection<TribClassificaReceitum> TribClassificaReceita { get; set; }
        public virtual ICollection<TribCmtipoConstrucao> TribCmtipoConstrucaos { get; set; }
        public virtual ICollection<TribCoeficienteTaxasIptu> TribCoeficienteTaxasIptus { get; set; }
        public virtual ICollection<TribComposicaoDivContribuinte> TribComposicaoDivContribuintes { get; set; }
        public virtual ICollection<TribComposicaoDivEmpresa> TribComposicaoDivEmpresas { get; set; }
        public virtual ICollection<TribComposicaoDivImo> TribComposicaoDivImos { get; set; }
        public virtual ICollection<TribDividasEmpresa> TribDividasEmpresas { get; set; }
        public virtual ICollection<TribDividasImoEdital> TribDividasImoEditals { get; set; }
        public virtual ICollection<TribDividasImo> TribDividasImos { get; set; }
        public virtual ICollection<TribEdificacoesIsencaoTrib> TribEdificacoesIsencaoTribs { get; set; }
        public virtual ICollection<TribEmpresasLimitesTaxa> TribEmpresasLimitesTaxas { get; set; }
        public virtual ICollection<TribEmpresasTipoAlvaraTributo> TribEmpresasTipoAlvaraTributos { get; set; }
        public virtual ICollection<TribEmpresasTributo> TribEmpresasTributos { get; set; }
        public virtual ICollection<TribFiscItensVistoriaTributo> TribFiscItensVistoriaTributos { get; set; }
        public virtual ICollection<TribIsencaoIncidencium> TribIsencaoIncidencia { get; set; }
        public virtual ICollection<TribIssqnestimado> TribIssqnestimados { get; set; }
        public virtual ICollection<TribItbiedif> TribItbiedifs { get; set; }
        public virtual ICollection<TribLeisDescTributo> TribLeisDescTributos { get; set; }
        public virtual ICollection<TribLeisDesc> TribLeisDescs { get; set; }
        public virtual ICollection<TribQuadraLogradTributo> TribQuadraLogradTributos { get; set; }
        public virtual ICollection<TribSimuladosEmpresaDiv> TribSimuladosEmpresaDivs { get; set; }
        public virtual ICollection<TribTapMapa> TribTapMapas { get; set; }
        public virtual ICollection<TribTipoProcessoTributo> TribTipoProcessoTributos { get; set; }
        public virtual ICollection<TribTipoTributosTipoProcesso> TribTipoTributosTipoProcessos { get; set; }
        public virtual ICollection<TribTipoTributosVenc> TribTipoTributosVencs { get; set; }
        public virtual ICollection<TribUtilizTributo> TribUtilizTributos { get; set; }

        public virtual ICollection<TribSecao> Secaos { get; set; }
        public virtual ICollection<TribTipoIsencao> TipoIses { get; set; }
        public virtual ICollection<Usuario> Usus { get; set; }
    }
}

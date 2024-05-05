using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribTipoTributo
{
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

    public virtual ICollection<AguaCategoriaTributo> AguaCategoriaTributos { get; set; } = new List<AguaCategoriaTributo>();

    public virtual ConvenioBanco? Convenio { get; set; }

    public virtual ICollection<FissServicoTributo> FissServicoTributos { get; set; } = new List<FissServicoTributo>();

    public virtual ICollection<FissTipoServicoTributo> FissTipoServicoTributos { get; set; } = new List<FissTipoServicoTributo>();

    public virtual ICollection<FissTributosDespachosEmpresa> FissTributosDespachosEmpresas { get; set; } = new List<FissTributosDespachosEmpresa>();

    public virtual ICollection<SimamtributosEquivalencium> SimamtributosEquivalencia { get; set; } = new List<SimamtributosEquivalencium>();

    public virtual TribTipoTributosGrupo? TrGr { get; set; }

    public virtual TribTipoTributoOrigem? TrOr { get; set; }

    public virtual ICollection<TribAlvCalculo> TribAlvCalculos { get; set; } = new List<TribAlvCalculo>();

    public virtual ICollection<TribAlvTipoCalculo> TribAlvTipoCalculos { get; set; } = new List<TribAlvTipoCalculo>();

    public virtual ICollection<TribAtivSetorTributo> TribAtivSetorTributos { get; set; } = new List<TribAtivSetorTributo>();

    public virtual ICollection<TribAtivTributosEmpresa> TribAtivTributosEmpresas { get; set; } = new List<TribAtivTributosEmpresa>();

    public virtual ICollection<TribAtividadeTipoAlvaraTributo> TribAtividadeTipoAlvaraTributos { get; set; } = new List<TribAtividadeTipoAlvaraTributo>();

    public virtual ICollection<TribBaixaDevolucaoDividasComp> TribBaixaDevolucaoDividasComps { get; set; } = new List<TribBaixaDevolucaoDividasComp>();

    public virtual ICollection<TribClassificaReceitum> TribClassificaReceita { get; set; } = new List<TribClassificaReceitum>();

    public virtual ICollection<TribCmtipoConstrucao> TribCmtipoConstrucaos { get; set; } = new List<TribCmtipoConstrucao>();

    public virtual ICollection<TribCoeficienteTaxasIptu> TribCoeficienteTaxasIptus { get; set; } = new List<TribCoeficienteTaxasIptu>();

    public virtual ICollection<TribComposicaoDivContribuinte> TribComposicaoDivContribuintes { get; set; } = new List<TribComposicaoDivContribuinte>();

    public virtual ICollection<TribComposicaoDivEmpresa> TribComposicaoDivEmpresas { get; set; } = new List<TribComposicaoDivEmpresa>();

    public virtual ICollection<TribComposicaoDivImo> TribComposicaoDivImos { get; set; } = new List<TribComposicaoDivImo>();

    public virtual ICollection<TribDividasEmpresa> TribDividasEmpresas { get; set; } = new List<TribDividasEmpresa>();

    public virtual ICollection<TribDividasImoEdital> TribDividasImoEditals { get; set; } = new List<TribDividasImoEdital>();

    public virtual ICollection<TribDividasImo> TribDividasImos { get; set; } = new List<TribDividasImo>();

    public virtual ICollection<TribEdificacoesIsencaoTrib> TribEdificacoesIsencaoTribs { get; set; } = new List<TribEdificacoesIsencaoTrib>();

    public virtual ICollection<TribEmpresasLimitesTaxa> TribEmpresasLimitesTaxas { get; set; } = new List<TribEmpresasLimitesTaxa>();

    public virtual ICollection<TribEmpresasTipoAlvaraTributo> TribEmpresasTipoAlvaraTributos { get; set; } = new List<TribEmpresasTipoAlvaraTributo>();

    public virtual ICollection<TribEmpresasTributo> TribEmpresasTributos { get; set; } = new List<TribEmpresasTributo>();

    public virtual ICollection<TribFiscItensVistoriaTributo> TribFiscItensVistoriaTributos { get; set; } = new List<TribFiscItensVistoriaTributo>();

    public virtual ICollection<TribIsencaoIncidencium> TribIsencaoIncidencia { get; set; } = new List<TribIsencaoIncidencium>();

    public virtual ICollection<TribIssqnestimado> TribIssqnestimados { get; set; } = new List<TribIssqnestimado>();

    public virtual ICollection<TribItbiedif> TribItbiedifs { get; set; } = new List<TribItbiedif>();

    public virtual ICollection<TribLeisDescTributo> TribLeisDescTributos { get; set; } = new List<TribLeisDescTributo>();

    public virtual ICollection<TribLeisDesc> TribLeisDescs { get; set; } = new List<TribLeisDesc>();

    public virtual ICollection<TribQuadraLogradTributo> TribQuadraLogradTributos { get; set; } = new List<TribQuadraLogradTributo>();

    public virtual ICollection<TribSimuladosEmpresaDiv> TribSimuladosEmpresaDivs { get; set; } = new List<TribSimuladosEmpresaDiv>();

    public virtual ICollection<TribTapMapa> TribTapMapas { get; set; } = new List<TribTapMapa>();

    public virtual ICollection<TribTipoProcessoTributo> TribTipoProcessoTributos { get; set; } = new List<TribTipoProcessoTributo>();

    public virtual ICollection<TribTipoTributosTipoProcesso> TribTipoTributosTipoProcessos { get; set; } = new List<TribTipoTributosTipoProcesso>();

    public virtual ICollection<TribTipoTributosVenc> TribTipoTributosVencs { get; set; } = new List<TribTipoTributosVenc>();

    public virtual ICollection<TribUtilizTributo> TribUtilizTributos { get; set; } = new List<TribUtilizTributo>();

    public virtual ICollection<TribSecao> Secaos { get; set; } = new List<TribSecao>();

    public virtual ICollection<TribTipoIsencao> TipoIses { get; set; } = new List<TribTipoIsencao>();

    public virtual ICollection<Usuario> Usus { get; set; } = new List<Usuario>();
}

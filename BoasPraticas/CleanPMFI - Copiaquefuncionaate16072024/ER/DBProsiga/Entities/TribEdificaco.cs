using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEdificaco
{
    public long EdificacaoId { get; set; }

    public long? TerrenoId { get; set; }

    public string? EdifMatricula { get; set; }

    public int? EdifNumOficio { get; set; }

    public string? EdifAlvara { get; set; }

    /// <summary>
    /// domínio: Predial / Territorial
    /// </summary>
    public string? EdifCaracteristica { get; set; }

    public string? EdifNumeracao { get; set; }

    public long? DenoId { get; set; }

    public long? EdifEdificacaoEnglobamento { get; set; }

    public DateTime? EdifDtUltTransfPropriedade { get; set; }

    public DateTime? EdifDtInicioConstrucao { get; set; }

    public DateTime? EdifDtParalizacaoConstrucao { get; set; }

    public int? AgrupaId { get; set; }

    public int? AcabIntId { get; set; }

    public int? SituacaoId { get; set; }

    public int? PosicaoId { get; set; }

    public int? UsoId { get; set; }

    public int? UtilizId { get; set; }

    public int? PisoId { get; set; }

    public int? EletricaId { get; set; }

    public int? ForroId { get; set; }

    public int? CobertId { get; set; }

    public int? AcabExtId { get; set; }

    public int? CategId { get; set; }

    public int? EstrutId { get; set; }

    public int? TipoConId { get; set; }

    public int? OcupaId { get; set; }

    public int? EdifNumElevadores { get; set; }

    public int? EdifAnoConstrucao { get; set; }

    public int? EdifNumPavimento { get; set; }

    public int? EdifAndarConstrucao { get; set; }

    public decimal? EdifAreaConstruida { get; set; }

    public decimal? EdifAreaCoberta { get; set; }

    /// <summary>
    /// Informa se eh uma edificacao gerada automaticamente pelo terreno
    /// </summary>
    public string EdifContinuacaoTerreno { get; set; } = null!;

    public string? EdifEconomia { get; set; }

    public string InscricaoImobiliaria { get; set; } = null!;

    public string InscricaoImobiliariaGeo { get; set; } = null!;

    public decimal EdifFracaoIdealEdificacao { get; set; }

    public int? EdifPontosEdificacao { get; set; }

    public string? EdifComplemento { get; set; }

    public string? EdifNumAptoSalaLoja { get; set; }

    public string? EdifBloco { get; set; }

    public int? ParedeId { get; set; }

    public int? EsquadriasId { get; set; }

    public int? EstConservId { get; set; }

    /// <summary>
    /// Valor Venal para o Calculo do IPTU (ja considerado a fração do Terreno)
    /// </summary>
    public decimal? ValorVenalCalculo { get; set; }

    public long? NumeroCadastroCanadas { get; set; }

    /// <summary>
    /// Informação do CANADAS
    /// </summary>
    public int? UnidadeLote { get; set; }

    public long? EdifJuntarAoCarne { get; set; }

    /// <summary>
    /// Valor Venal da Edificação (trigger)
    /// </summary>
    public decimal? ValorVenalEdificacao { get; set; }

    /// <summary>
    /// Informa se o Imovel esta Normal ou Removido
    /// </summary>
    public string? EdifSituacao { get; set; }

    /// <summary>
    /// Incidencia de Tributos para a Edificacao
    /// </summary>
    public int? InciId { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public int? LogradId { get; set; }

    public int? Idloteamento { get; set; }

    public string? EdifCep { get; set; }

    /// <summary>
    /// Protocolo referente alterações de dados da edificação.
    /// </summary>
    public long? ProcId { get; set; }

    /// <summary>
    /// Motivo da alteração nos dados da edificação.
    /// </summary>
    public string? EdifMotivoAlteracao { get; set; }

    /// <summary>
    /// Data da matricula no cartório.
    /// </summary>
    public DateTime? EdifDtMatricula { get; set; }

    /// <summary>
    /// Valor da Longitude na Area Central da Edificação
    /// </summary>
    public string? EdifCentroGrauLon { get; set; }

    /// <summary>
    /// Valor da Latitude  na Area Central da Edificação
    /// </summary>
    public string? EdifCentroGrauLat { get; set; }

    public int? Idplanta { get; set; }

    /// <summary>
    /// Valor venal do terreno da edificação utilizado para calcular o IPTU, devido a alteração do FATOR K na lei do iptu de 2006.
    /// </summary>
    public decimal? ValorVenalTerrenoParaEdificacao { get; set; }

    /// <summary>
    /// Observacoes sobre a inscricao.
    /// </summary>
    public string? EdifObs { get; set; }

    public DateTime? EdifDataAtualizacaoEndereco { get; set; }

    public string? EdifUsuarioAtualizacaoEndereco { get; set; }

    /// <summary>
    /// Campo utilizado para a revisão cadastral do SEBRAE, sendo: 1 - Ok, 0 - Erro, null - não conferido
    /// </summary>
    public bool? Flconferido { get; set; }

    /// <summary>
    /// Campo utilizado para a revisão cadastral do SEBRAE.
    /// </summary>
    public string? Dsobservacao { get; set; }

    /// <summary>
    /// Campo utilizado para a revisão cadastral do SEBRAE.
    /// </summary>
    public int? TmpIdlogradouro { get; set; }

    /// <summary>
    /// Campo utilizado para a revisão cadastral do SEBRAE.
    /// </summary>
    public int? TmpIdzoneamento { get; set; }

    /// <summary>
    /// ID do usuário (RP) que fez a revisão.
    /// </summary>
    public int? Idusuariorevisao { get; set; }

    public virtual TribAcabamentoExterno? AcabExt { get; set; }

    public virtual TribAcabamentoInterno? AcabInt { get; set; }

    public virtual TribAgrupamento? Agrupa { get; set; }

    public virtual ICollection<AguaEdificacoesHidrometro> AguaEdificacoesHidrometros { get; set; } = new List<AguaEdificacoesHidrometro>();

    public virtual TribCobertura? Cobert { get; set; }

    public virtual TribDenominacao? Deno { get; set; }

    public virtual TribInstalacaoEletrica? Eletrica { get; set; }

    public virtual TribEsquadria? Esquadrias { get; set; }

    public virtual TribEstadoConservacao? EstConserv { get; set; }

    public virtual TribEstruturaParede? Estrut { get; set; }

    public virtual TribForro? Forro { get; set; }

    public virtual Loteamento? IdloteamentoNavigation { get; set; }

    public virtual TribTipoPlantasValore? IdplantaNavigation { get; set; }

    public virtual TribIncidencium? Inci { get; set; }

    public virtual Logradouro? Lograd { get; set; }

    public virtual TribOcupacao? Ocupa { get; set; }

    public virtual TribParede? Parede { get; set; }

    public virtual TribPiso? Piso { get; set; }

    public virtual TribPosicaoEdificacao? Posicao { get; set; }

    public virtual TribSituacaoEdificacao? Situacao { get; set; }

    public virtual TribTerreno? Terreno { get; set; }

    public virtual TribTiposConstrucao? TipoCon { get; set; }

    public virtual ICollection<TribAcompAnterior> TribAcompAnteriors { get; set; } = new List<TribAcompAnterior>();

    public virtual ICollection<TribAlvaraConstrucao> TribAlvaraConstrucaos { get; set; } = new List<TribAlvaraConstrucao>();

    public virtual ICollection<TribAutosInfracao> TribAutosInfracaos { get; set; } = new List<TribAutosInfracao>();

    public virtual ICollection<TribBonificacao> TribBonificacaos { get; set; } = new List<TribBonificacao>();

    public virtual ICollection<TribCmedificacaoProcesso> TribCmedificacaoProcessos { get; set; } = new List<TribCmedificacaoProcesso>();

    public virtual ICollection<TribCmoficio> TribCmoficios { get; set; } = new List<TribCmoficio>();

    public virtual ICollection<TribDividasImoEdital> TribDividasImoEditals { get; set; } = new List<TribDividasImoEdital>();

    public virtual ICollection<TribDividasImo> TribDividasImos { get; set; } = new List<TribDividasImo>();

    public virtual ICollection<TribDocumentosIptu> TribDocumentosIptus { get; set; } = new List<TribDocumentosIptu>();

    public virtual ICollection<TribEdifAtributosDinamico> TribEdifAtributosDinamicos { get; set; } = new List<TribEdifAtributosDinamico>();

    public virtual ICollection<TribEdifInstSanitarium> TribEdifInstSanitaria { get; set; } = new List<TribEdifInstSanitarium>();

    public virtual ICollection<TribEdifNumPredial> TribEdifNumPredials { get; set; } = new List<TribEdifNumPredial>();

    public virtual ICollection<TribEdifParamCalculo> TribEdifParamCalculos { get; set; } = new List<TribEdifParamCalculo>();

    public virtual ICollection<TribEdificacoesBloqueada> TribEdificacoesBloqueada { get; set; } = new List<TribEdificacoesBloqueada>();

    public virtual ICollection<TribEdificacoesCancelada> TribEdificacoesCancelada { get; set; } = new List<TribEdificacoesCancelada>();

    public virtual ICollection<TribEdificacoesCertidaoPredial> TribEdificacoesCertidaoPredials { get; set; } = new List<TribEdificacoesCertidaoPredial>();

    public virtual ICollection<TribEdificacoesContrib> TribEdificacoesContribs { get; set; } = new List<TribEdificacoesContrib>();

    public virtual ICollection<TribEdificacoesEndereco> TribEdificacoesEnderecos { get; set; } = new List<TribEdificacoesEndereco>();

    public virtual ICollection<TribEdificacoesImagen> TribEdificacoesImagens { get; set; } = new List<TribEdificacoesImagen>();

    public virtual ICollection<TribEdificacoesInsencoesMinhaCasa> TribEdificacoesInsencoesMinhaCasas { get; set; } = new List<TribEdificacoesInsencoesMinhaCasa>();

    public virtual ICollection<TribEdificacoesIsencao> TribEdificacoesIsencaos { get; set; } = new List<TribEdificacoesIsencao>();

    public virtual ICollection<TribEdificacoesValorVenalTemp> TribEdificacoesValorVenalTemps { get; set; } = new List<TribEdificacoesValorVenalTemp>();

    public virtual ICollection<TribEmpresasEdificaco> TribEmpresasEdificacos { get; set; } = new List<TribEmpresasEdificaco>();

    public virtual ICollection<TribFiscVistoria> TribFiscVistoria { get; set; } = new List<TribFiscVistoria>();

    public virtual ICollection<TribItbiedif> TribItbiedifs { get; set; } = new List<TribItbiedif>();

    public virtual ICollection<TribItbiexEdif> TribItbiexEdifs { get; set; } = new List<TribItbiexEdif>();

    public virtual ICollection<TribProtocoloAlteracao> TribProtocoloAlteracaos { get; set; } = new List<TribProtocoloAlteracao>();

    public virtual ICollection<TribRequerimentoRevisaoImovei> TribRequerimentoRevisaoImoveis { get; set; } = new List<TribRequerimentoRevisaoImovei>();

    public virtual ICollection<TribSimuladosIptuimovei> TribSimuladosIptuimoveis { get; set; } = new List<TribSimuladosIptuimovei>();

    public virtual ICollection<TribTapInscrOrigem> TribTapInscrOrigems { get; set; } = new List<TribTapInscrOrigem>();

    public virtual ICollection<TribTap> TribTaps { get; set; } = new List<TribTap>();

    public virtual ICollection<TribTransfDivida> TribTransfDividaEdificacaoIddestinoNavigations { get; set; } = new List<TribTransfDivida>();

    public virtual ICollection<TribTransfDivida> TribTransfDividaEdificacaoIdorigemNavigations { get; set; } = new List<TribTransfDivida>();

    public virtual ICollection<TribTransferencia> TribTransferencia { get; set; } = new List<TribTransferencia>();

    public virtual ICollection<Tribedificacoesdivergencium> Tribedificacoesdivergencia { get; set; } = new List<Tribedificacoesdivergencium>();

    public virtual TribUso? Uso { get; set; }

    public virtual TribUtilizacao? Utiliz { get; set; }

    public virtual ICollection<TribEquipamento> Equips { get; set; } = new List<TribEquipamento>();
}

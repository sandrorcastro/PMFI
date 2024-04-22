using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEdificaco
    {
        public TribEdificaco()
        {
            AguaEdificacoesHidrometros = new HashSet<AguaEdificacoesHidrometro>();
            TribAcompAnteriors = new HashSet<TribAcompAnterior>();
            TribAlvaraConstrucaos = new HashSet<TribAlvaraConstrucao>();
            TribAutosInfracaos = new HashSet<TribAutosInfracao>();
            TribBonificacaos = new HashSet<TribBonificacao>();
            TribCmedificacaoProcessos = new HashSet<TribCmedificacaoProcesso>();
            TribCmoficios = new HashSet<TribCmoficio>();
            TribDividasImoEditals = new HashSet<TribDividasImoEdital>();
            TribDividasImos = new HashSet<TribDividasImo>();
            TribDocumentosIptus = new HashSet<TribDocumentosIptu>();
            TribEdifAtributosDinamicos = new HashSet<TribEdifAtributosDinamico>();
            TribEdifInstSanitaria = new HashSet<TribEdifInstSanitarium>();
            TribEdifNumPredials = new HashSet<TribEdifNumPredial>();
            TribEdifParamCalculos = new HashSet<TribEdifParamCalculo>();
            TribEdificacoesBloqueada = new HashSet<TribEdificacoesBloqueada>();
            TribEdificacoesCancelada = new HashSet<TribEdificacoesCancelada>();
            TribEdificacoesCertidaoPredials = new HashSet<TribEdificacoesCertidaoPredial>();
            TribEdificacoesContribs = new HashSet<TribEdificacoesContrib>();
            TribEdificacoesEnderecos = new HashSet<TribEdificacoesEndereco>();
            TribEdificacoesImagens = new HashSet<TribEdificacoesImagen>();
            TribEdificacoesInsencoesMinhaCasas = new HashSet<TribEdificacoesInsencoesMinhaCasa>();
            TribEdificacoesIsencaos = new HashSet<TribEdificacoesIsencao>();
            TribEdificacoesValorVenalTemps = new HashSet<TribEdificacoesValorVenalTemp>();
            TribEmpresasEdificacos = new HashSet<TribEmpresasEdificaco>();
            TribFiscVistoria = new HashSet<TribFiscVistoria>();
            TribItbiedifs = new HashSet<TribItbiedif>();
            TribItbiexEdifs = new HashSet<TribItbiexEdif>();
            TribProtocoloAlteracaos = new HashSet<TribProtocoloAlteracao>();
            TribRequerimentoRevisaoImoveis = new HashSet<TribRequerimentoRevisaoImovei>();
            TribSimuladosIptuimoveis = new HashSet<TribSimuladosIptuimovei>();
            TribTapInscrOrigems = new HashSet<TribTapInscrOrigem>();
            TribTaps = new HashSet<TribTap>();
            TribTransfDividaEdificacaoIddestinoNavigations = new HashSet<TribTransfDivida>();
            TribTransfDividaEdificacaoIdorigemNavigations = new HashSet<TribTransfDivida>();
            TribTransferencia = new HashSet<TribTransferencia>();
            Tribedificacoesdivergencia = new HashSet<Tribedificacoesdivergencium>();
            Equips = new HashSet<TribEquipamento>();
        }

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
        public virtual TribUso? Uso { get; set; }
        public virtual TribUtilizacao? Utiliz { get; set; }
        public virtual ICollection<AguaEdificacoesHidrometro> AguaEdificacoesHidrometros { get; set; }
        public virtual ICollection<TribAcompAnterior> TribAcompAnteriors { get; set; }
        public virtual ICollection<TribAlvaraConstrucao> TribAlvaraConstrucaos { get; set; }
        public virtual ICollection<TribAutosInfracao> TribAutosInfracaos { get; set; }
        public virtual ICollection<TribBonificacao> TribBonificacaos { get; set; }
        public virtual ICollection<TribCmedificacaoProcesso> TribCmedificacaoProcessos { get; set; }
        public virtual ICollection<TribCmoficio> TribCmoficios { get; set; }
        public virtual ICollection<TribDividasImoEdital> TribDividasImoEditals { get; set; }
        public virtual ICollection<TribDividasImo> TribDividasImos { get; set; }
        public virtual ICollection<TribDocumentosIptu> TribDocumentosIptus { get; set; }
        public virtual ICollection<TribEdifAtributosDinamico> TribEdifAtributosDinamicos { get; set; }
        public virtual ICollection<TribEdifInstSanitarium> TribEdifInstSanitaria { get; set; }
        public virtual ICollection<TribEdifNumPredial> TribEdifNumPredials { get; set; }
        public virtual ICollection<TribEdifParamCalculo> TribEdifParamCalculos { get; set; }
        public virtual ICollection<TribEdificacoesBloqueada> TribEdificacoesBloqueada { get; set; }
        public virtual ICollection<TribEdificacoesCancelada> TribEdificacoesCancelada { get; set; }
        public virtual ICollection<TribEdificacoesCertidaoPredial> TribEdificacoesCertidaoPredials { get; set; }
        public virtual ICollection<TribEdificacoesContrib> TribEdificacoesContribs { get; set; }
        public virtual ICollection<TribEdificacoesEndereco> TribEdificacoesEnderecos { get; set; }
        public virtual ICollection<TribEdificacoesImagen> TribEdificacoesImagens { get; set; }
        public virtual ICollection<TribEdificacoesInsencoesMinhaCasa> TribEdificacoesInsencoesMinhaCasas { get; set; }
        public virtual ICollection<TribEdificacoesIsencao> TribEdificacoesIsencaos { get; set; }
        public virtual ICollection<TribEdificacoesValorVenalTemp> TribEdificacoesValorVenalTemps { get; set; }
        public virtual ICollection<TribEmpresasEdificaco> TribEmpresasEdificacos { get; set; }
        public virtual ICollection<TribFiscVistoria> TribFiscVistoria { get; set; }
        public virtual ICollection<TribItbiedif> TribItbiedifs { get; set; }
        public virtual ICollection<TribItbiexEdif> TribItbiexEdifs { get; set; }
        public virtual ICollection<TribProtocoloAlteracao> TribProtocoloAlteracaos { get; set; }
        public virtual ICollection<TribRequerimentoRevisaoImovei> TribRequerimentoRevisaoImoveis { get; set; }
        public virtual ICollection<TribSimuladosIptuimovei> TribSimuladosIptuimoveis { get; set; }
        public virtual ICollection<TribTapInscrOrigem> TribTapInscrOrigems { get; set; }
        public virtual ICollection<TribTap> TribTaps { get; set; }
        public virtual ICollection<TribTransfDivida> TribTransfDividaEdificacaoIddestinoNavigations { get; set; }
        public virtual ICollection<TribTransfDivida> TribTransfDividaEdificacaoIdorigemNavigations { get; set; }
        public virtual ICollection<TribTransferencia> TribTransferencia { get; set; }
        public virtual ICollection<Tribedificacoesdivergencium> Tribedificacoesdivergencia { get; set; }

        public virtual ICollection<TribEquipamento> Equips { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresa
    {
        public TribEmpresa()
        {
            FissContribEmpresas = new HashSet<FissContribEmpresa>();
            FissDespachosEmpresas = new HashSet<FissDespachosEmpresa>();
            FissDocFiscais = new HashSet<FissDocFiscai>();
            FissDoctosAnexosEmpresas = new HashSet<FissDoctosAnexosEmpresa>();
            FissServicos = new HashSet<FissServico>();
            FissTomadorPrestadors = new HashSet<FissTomadorPrestador>();
            SerIturEmpresaInfraEstruturas = new HashSet<SerIturEmpresaInfraEstrutura>();
            SerIturObjetoEmpresas = new HashSet<SerIturObjetoEmpresa>();
            SeriTurMovAtendimentos = new HashSet<SeriTurMovAtendimento>();
            SeriturPublicaEmpresas = new HashSet<SeriturPublicaEmpresa>();
            TribAcompAnteriors = new HashSet<TribAcompAnterior>();
            TribAlvaraEmpresas = new HashSet<TribAlvaraEmpresa>();
            TribAutorizacaoBlocosNfs = new HashSet<TribAutorizacaoBlocosNf>();
            TribAutosInfracaos = new HashSet<TribAutosInfracao>();
            TribDividasEmpresas = new HashSet<TribDividasEmpresa>();
            TribEmpresaAnexos = new HashSet<TribEmpresaAnexo>();
            TribEmpresasAtivs = new HashSet<TribEmpresasAtiv>();
            TribEmpresasEdificacos = new HashSet<TribEmpresasEdificaco>();
            TribEmpresasEnquadramentos = new HashSet<TribEmpresasEnquadramento>();
            TribEmpresasMovSituacaos = new HashSet<TribEmpresasMovSituacao>();
            TribEmpresasPublicidades = new HashSet<TribEmpresasPublicidade>();
            TribEmpresasServicos = new HashSet<TribEmpresasServico>();
            TribEmpresasSimplesMovs = new HashSet<TribEmpresasSimplesMov>();
            TribEmpresasSociosProfissionais = new HashSet<TribEmpresasSociosProfissionai>();
            TribEmpresasTipoAlvaraTributos = new HashSet<TribEmpresasTipoAlvaraTributo>();
            TribEmpresasTributos = new HashSet<TribEmpresasTributo>();
            TribEmpresasVigilanciaSanitaria = new HashSet<TribEmpresasVigilanciaSanitarium>();
            TribFiscVistoria = new HashSet<TribFiscVistoria>();
            TribIssqnestimados = new HashSet<TribIssqnestimado>();
            TribProtocoloAlteracaos = new HashSet<TribProtocoloAlteracao>();
            TribSimplesNacionalOcorrEventos = new HashSet<TribSimplesNacionalOcorrEvento>();
            TribSimuladosEmpresas = new HashSet<TribSimuladosEmpresa>();
            TribTapInscrOrigems = new HashSet<TribTapInscrOrigem>();
            TribTaps = new HashSet<TribTap>();
            TribTransfDividaEmprCmcDestinoNavigations = new HashSet<TribTransfDivida>();
            TribTransfDividaEmprCmcOrigemNavigations = new HashSet<TribTransfDivida>();
        }

        public long EmprCmc { get; set; }
        public long? ConId { get; set; }
        public int? LogradId { get; set; }
        public string? EmprEnderecoNum { get; set; }
        public int? BairroId { get; set; }
        public int? CidadeId { get; set; }
        public string? EmprComplemento { get; set; }
        public long? ContadorId { get; set; }
        public long? EmprRegJuntaCom { get; set; }
        public DateTime? EmprRegJuntaComData { get; set; }
        public string? EstabGrupo { get; set; }
        public decimal? EmprAreaAberta { get; set; }
        public decimal? AnteriorAreaConstr { get; set; }
        public int? AnteriorNumPavimento { get; set; }
        /// <summary>
        /// Sim ou Não
        /// </summary>
        public string? EmprAlvaraEventual { get; set; }
        public int? EmprSituacaoId { get; set; }
        public int? EmprNumEmpregados { get; set; }
        public string? EmprComGas { get; set; }
        public string? EmprComExplosivo { get; set; }
        public string? EmprComDiversoes { get; set; }
        public int? EmprHotelNumQuarto { get; set; }
        public int? EmprHotelNumApto { get; set; }
        public int? EmprHospitalNumLeitos { get; set; }
        public int? EmprJogosNumMesas { get; set; }
        public int? EmprJogosNumEletronicos { get; set; }
        public int? EmprJogosNumPista { get; set; }
        public int? EmprBarbeiroNumLug { get; set; }
        public int? EmprTeatroNumLug { get; set; }
        public int? EmprEnsinoNumSalas { get; set; }
        public string? EmprSubstituto { get; set; }
        public int? EmprTipoId { get; set; }
        public int? EmprConstitId { get; set; }
        public string? EmprCnpjextensao { get; set; }
        public int? EmprCaracId { get; set; }
        public string? EmprCep { get; set; }
        /// <summary>
        /// São as empresas ou autonomos NÃO ESTABELECIDOS
        /// </summary>
        public string EmprDomicilioTributario { get; set; } = null!;
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public short? EmprTipoEntidade { get; set; }
        public DateTime? EmprDtFinCadastro { get; set; }
        /// <summary>
        /// Descritivo da atividade do contrato social da empresa.
        /// </summary>
        public string? EmprAtividadeContratoSocial { get; set; }
        public string? EmprOrigemDuc { get; set; }
        public DateTime? EmprDataInscricao { get; set; }
        public string EmprEnqSimples { get; set; } = null!;
        public string? EmprRestricoes { get; set; }
        public string? EmprEmail { get; set; }
        public string? EmprEmailContador { get; set; }
        public int? IdGrupoRisco { get; set; }
        public string? EmprEnqSimei { get; set; }
        public string? ProtocoloConsultaPrevia { get; set; }
        public string? EmprInscricaoEstadual { get; set; }
        public byte? EmprRegime { get; set; }
        public DateTime? EmprDataAdesao { get; set; }
        public decimal? EmprAlicotaPrincipal { get; set; }
        public decimal? EmprValorEstimado { get; set; }
        public string? EmprTipoEmpresa { get; set; }
        public decimal? EmprValorMensal { get; set; }
        public string? EmprSubstitutoTributario { get; set; }
        public string? EmprEmpresaPublica { get; set; }
        /// <summary>
        /// Indica se a empresa foi aberta por um PRP de Alteração
        /// </summary>
        public string Flabertaporalteracao { get; set; } = null!;

        public virtual Bairro? Bairro { get; set; }
        public virtual Cidade? Cidade { get; set; }
        public virtual Contribuinte? Con { get; set; }
        public virtual TribContador? Contador { get; set; }
        public virtual TribEmpresasTipoCaracteristica? EmprCarac { get; set; }
        public virtual TribEmpresasTipoConstituicao? EmprConstit { get; set; }
        public virtual TribEmpresasTipoSituacao? EmprSituacao { get; set; }
        public virtual TribEmpresasTipo? EmprTipo { get; set; }
        public virtual TribEmpresasTipoEntidade? EmprTipoEntidadeNavigation { get; set; }
        public virtual TribGruposEstabelecimento? EstabGrupoNavigation { get; set; }
        public virtual Logradouro? Lograd { get; set; }
        public virtual ICollection<FissContribEmpresa> FissContribEmpresas { get; set; }
        public virtual ICollection<FissDespachosEmpresa> FissDespachosEmpresas { get; set; }
        public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; }
        public virtual ICollection<FissDoctosAnexosEmpresa> FissDoctosAnexosEmpresas { get; set; }
        public virtual ICollection<FissServico> FissServicos { get; set; }
        public virtual ICollection<FissTomadorPrestador> FissTomadorPrestadors { get; set; }
        public virtual ICollection<SerIturEmpresaInfraEstrutura> SerIturEmpresaInfraEstruturas { get; set; }
        public virtual ICollection<SerIturObjetoEmpresa> SerIturObjetoEmpresas { get; set; }
        public virtual ICollection<SeriTurMovAtendimento> SeriTurMovAtendimentos { get; set; }
        public virtual ICollection<SeriturPublicaEmpresa> SeriturPublicaEmpresas { get; set; }
        public virtual ICollection<TribAcompAnterior> TribAcompAnteriors { get; set; }
        public virtual ICollection<TribAlvaraEmpresa> TribAlvaraEmpresas { get; set; }
        public virtual ICollection<TribAutorizacaoBlocosNf> TribAutorizacaoBlocosNfs { get; set; }
        public virtual ICollection<TribAutosInfracao> TribAutosInfracaos { get; set; }
        public virtual ICollection<TribDividasEmpresa> TribDividasEmpresas { get; set; }
        public virtual ICollection<TribEmpresaAnexo> TribEmpresaAnexos { get; set; }
        public virtual ICollection<TribEmpresasAtiv> TribEmpresasAtivs { get; set; }
        public virtual ICollection<TribEmpresasEdificaco> TribEmpresasEdificacos { get; set; }
        public virtual ICollection<TribEmpresasEnquadramento> TribEmpresasEnquadramentos { get; set; }
        public virtual ICollection<TribEmpresasMovSituacao> TribEmpresasMovSituacaos { get; set; }
        public virtual ICollection<TribEmpresasPublicidade> TribEmpresasPublicidades { get; set; }
        public virtual ICollection<TribEmpresasServico> TribEmpresasServicos { get; set; }
        public virtual ICollection<TribEmpresasSimplesMov> TribEmpresasSimplesMovs { get; set; }
        public virtual ICollection<TribEmpresasSociosProfissionai> TribEmpresasSociosProfissionais { get; set; }
        public virtual ICollection<TribEmpresasTipoAlvaraTributo> TribEmpresasTipoAlvaraTributos { get; set; }
        public virtual ICollection<TribEmpresasTributo> TribEmpresasTributos { get; set; }
        public virtual ICollection<TribEmpresasVigilanciaSanitarium> TribEmpresasVigilanciaSanitaria { get; set; }
        public virtual ICollection<TribFiscVistoria> TribFiscVistoria { get; set; }
        public virtual ICollection<TribIssqnestimado> TribIssqnestimados { get; set; }
        public virtual ICollection<TribProtocoloAlteracao> TribProtocoloAlteracaos { get; set; }
        public virtual ICollection<TribSimplesNacionalOcorrEvento> TribSimplesNacionalOcorrEventos { get; set; }
        public virtual ICollection<TribSimuladosEmpresa> TribSimuladosEmpresas { get; set; }
        public virtual ICollection<TribTapInscrOrigem> TribTapInscrOrigems { get; set; }
        public virtual ICollection<TribTap> TribTaps { get; set; }
        public virtual ICollection<TribTransfDivida> TribTransfDividaEmprCmcDestinoNavigations { get; set; }
        public virtual ICollection<TribTransfDivida> TribTransfDividaEmprCmcOrigemNavigations { get; set; }
    }
}

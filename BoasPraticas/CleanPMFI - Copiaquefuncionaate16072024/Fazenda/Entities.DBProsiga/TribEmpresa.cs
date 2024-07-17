using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEmpresa
{
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

    public virtual ICollection<FissContribEmpresa> FissContribEmpresas { get; set; } = new List<FissContribEmpresa>();

    public virtual ICollection<FissDespachosEmpresa> FissDespachosEmpresas { get; set; } = new List<FissDespachosEmpresa>();

    public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; } = new List<FissDocFiscai>();

    public virtual ICollection<FissDoctosAnexosEmpresa> FissDoctosAnexosEmpresas { get; set; } = new List<FissDoctosAnexosEmpresa>();

    public virtual ICollection<FissServico> FissServicos { get; set; } = new List<FissServico>();

    public virtual ICollection<FissTomadorPrestador> FissTomadorPrestadors { get; set; } = new List<FissTomadorPrestador>();

    public virtual Logradouro? Lograd { get; set; }

    public virtual ICollection<SerIturEmpresaInfraEstrutura> SerIturEmpresaInfraEstruturas { get; set; } = new List<SerIturEmpresaInfraEstrutura>();

    public virtual ICollection<SerIturObjetoEmpresa> SerIturObjetoEmpresas { get; set; } = new List<SerIturObjetoEmpresa>();

    public virtual ICollection<SeriTurMovAtendimento> SeriTurMovAtendimentos { get; set; } = new List<SeriTurMovAtendimento>();

    public virtual ICollection<SeriturPublicaEmpresa> SeriturPublicaEmpresas { get; set; } = new List<SeriturPublicaEmpresa>();

    public virtual ICollection<TribAcompAnterior> TribAcompAnteriors { get; set; } = new List<TribAcompAnterior>();

    public virtual ICollection<TribAlvaraEmpresa> TribAlvaraEmpresas { get; set; } = new List<TribAlvaraEmpresa>();

    public virtual ICollection<TribAutorizacaoBlocosNf> TribAutorizacaoBlocosNfs { get; set; } = new List<TribAutorizacaoBlocosNf>();

    public virtual ICollection<TribAutosInfracao> TribAutosInfracaos { get; set; } = new List<TribAutosInfracao>();

    public virtual ICollection<TribDividasEmpresa> TribDividasEmpresas { get; set; } = new List<TribDividasEmpresa>();

    public virtual ICollection<TribEmpresaAnexo> TribEmpresaAnexos { get; set; } = new List<TribEmpresaAnexo>();

    public virtual ICollection<TribEmpresasAtiv> TribEmpresasAtivs { get; set; } = new List<TribEmpresasAtiv>();

    public virtual ICollection<TribEmpresasEdificaco> TribEmpresasEdificacos { get; set; } = new List<TribEmpresasEdificaco>();

    public virtual ICollection<TribEmpresasEnquadramento> TribEmpresasEnquadramentos { get; set; } = new List<TribEmpresasEnquadramento>();

    public virtual ICollection<TribEmpresasMovSituacao> TribEmpresasMovSituacaos { get; set; } = new List<TribEmpresasMovSituacao>();

    public virtual ICollection<TribEmpresasPublicidade> TribEmpresasPublicidades { get; set; } = new List<TribEmpresasPublicidade>();

    public virtual ICollection<TribEmpresasServico> TribEmpresasServicos { get; set; } = new List<TribEmpresasServico>();

    public virtual ICollection<TribEmpresasSimplesMov> TribEmpresasSimplesMovs { get; set; } = new List<TribEmpresasSimplesMov>();

    public virtual ICollection<TribEmpresasSociosProfissionai> TribEmpresasSociosProfissionais { get; set; } = new List<TribEmpresasSociosProfissionai>();

    public virtual ICollection<TribEmpresasTipoAlvaraTributo> TribEmpresasTipoAlvaraTributos { get; set; } = new List<TribEmpresasTipoAlvaraTributo>();

    public virtual ICollection<TribEmpresasTributo> TribEmpresasTributos { get; set; } = new List<TribEmpresasTributo>();

    public virtual ICollection<TribEmpresasVigilanciaSanitarium> TribEmpresasVigilanciaSanitaria { get; set; } = new List<TribEmpresasVigilanciaSanitarium>();

    public virtual ICollection<TribFiscVistoria> TribFiscVistoria { get; set; } = new List<TribFiscVistoria>();

    public virtual ICollection<TribIssqnestimado> TribIssqnestimados { get; set; } = new List<TribIssqnestimado>();

    public virtual ICollection<TribProtocoloAlteracao> TribProtocoloAlteracaos { get; set; } = new List<TribProtocoloAlteracao>();

    public virtual ICollection<TribSimplesNacionalOcorrEvento> TribSimplesNacionalOcorrEventos { get; set; } = new List<TribSimplesNacionalOcorrEvento>();

    public virtual ICollection<TribSimuladosEmpresa> TribSimuladosEmpresas { get; set; } = new List<TribSimuladosEmpresa>();

    public virtual ICollection<TribTapInscrOrigem> TribTapInscrOrigems { get; set; } = new List<TribTapInscrOrigem>();

    public virtual ICollection<TribTap> TribTaps { get; set; } = new List<TribTap>();

    public virtual ICollection<TribTransfDivida> TribTransfDividaEmprCmcDestinoNavigations { get; set; } = new List<TribTransfDivida>();

    public virtual ICollection<TribTransfDivida> TribTransfDividaEmprCmcOrigemNavigations { get; set; } = new List<TribTransfDivida>();
}

using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Contribuinte
{
    /// <summary>
    /// Código de Identificação da Pessoa (Contribuinte).
    /// </summary>
    public long ConId { get; set; }

    /// <summary>
    /// FISICA, JURIDICA, NENHUM, ESTRANGEIRO
    /// </summary>
    public string ConTipoPessoa { get; set; } = null!;

    /// <summary>
    /// Razao Social ou Nome Completo do Contribuinte. 
    /// </summary>
    public string? ConNome { get; set; }

    public string? ConCnpjcpf { get; set; }

    public string? ConNomeFantasia { get; set; }

    public string? ConInscrEstadual { get; set; }

    public string? ConCargo { get; set; }

    public string? ConFuncao { get; set; }

    /// <summary>
    /// Cadastro Municipal de Contribuintes
    /// </summary>
    public long? ConCmc { get; set; }

    public DateTime? ConDtNasc { get; set; }

    public string? ConSexo { get; set; }

    public string? ConRg { get; set; }

    public DateTime? ConRgdtEmissao { get; set; }

    public string? ConRgorgaoExp { get; set; }

    public string? ConRgufexp { get; set; }

    public string? ConNumTitulo { get; set; }

    public long? ConNumHabilitacao { get; set; }

    public string? ConCatHabilitacao { get; set; }

    public int? ConIdtipoDocumento { get; set; }

    public string? ConNrDocumento { get; set; }

    public string? ConUfdocumento { get; set; }

    public string? ConNacionalidade { get; set; }

    public string? ConNacCorrigida { get; set; }

    public string? ConEstadoCivil { get; set; }

    public string? ConProfissao { get; set; }

    public string? ConTelefones { get; set; }

    public string? ConTelefoneResidencial { get; set; }

    public string? ConTelefoneComercial { get; set; }

    public string? ConTelefoneCelular { get; set; }

    public string? ConEmail { get; set; }

    public string? ConCep { get; set; }

    public string? ConTipoLograd { get; set; }

    /// <summary>
    /// Nome do Logradouro de residencia da pessoa
    /// </summary>
    public string? ConEndereco { get; set; }

    public string? ConNumero { get; set; }

    public string? ConComplemento { get; set; }

    /// <summary>
    /// Código de Identificação do Bairro de Residencia(Moradia).
    /// </summary>
    public int? ConBairroId { get; set; }

    /// <summary>
    /// Código de Identificação da Cidade de Residencia(Moradia).
    /// </summary>
    public int? ConCidadeId { get; set; }

    public int? ConCidNascId { get; set; }

    public string? ConRespRg { get; set; }

    public string? ConRespNome { get; set; }

    public byte[]? ConFoto { get; set; }

    /// <summary>
    /// Código de identificação do conjuge. Utiliza o ID da mesma entidade &quot;Contribuintes&quot; para gravar, sendo que existe uma trigger sicronizando os conjuges. Marido X Esposa e Esposa X Marido.
    /// </summary>
    public long? ConIdconjuge { get; set; }

    public string? ConSite { get; set; }

    public string? ConIdanterior { get; set; }

    public decimal? ConRendaMensal { get; set; }

    public string? ConFalecido { get; set; }

    public string? ConGrafica { get; set; }

    public DateTime? ConDtBaseTce { get; set; }

    public int? ConIdcbo { get; set; }

    public string? ConNomeMae { get; set; }

    public string? ConTecUltAlt { get; set; }

    public DateTime? ConDtUltAlt { get; set; }

    public byte[]? ConSenha { get; set; }

    public DateTime? ConDtValidadeSenha { get; set; }

    public DateTime? ConDtCriaSenha { get; set; }

    public string? ConFonetizado { get; set; }

    public int? ConIdnacionalidade { get; set; }

    public string? TmpConFoneAuxiliar { get; set; }

    /// <summary>
    /// FISICA, JURIDICA, NENHUM, ESTRANGEIRO
    /// </summary>
    public string? TmpTipoPessoa { get; set; }

    public virtual ICollection<Acessorio> Acessorios { get; set; } = new List<Acessorio>();

    public virtual ICollection<AcessoriosMoveisEquipamento> AcessoriosMoveisEquipamentos { get; set; } = new List<AcessoriosMoveisEquipamento>();

    public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; } = new List<AgeAgendamento>();

    public virtual ICollection<AguaReqSolicitacaoServico> AguaReqSolicitacaoServicos { get; set; } = new List<AguaReqSolicitacaoServico>();

    public virtual ICollection<AlmEntrada> AlmEntrada { get; set; } = new List<AlmEntrada>();

    public virtual ICollection<BaixaImoveisImoben> BaixaImoveisImobens { get; set; } = new List<BaixaImoveisImoben>();

    public virtual ICollection<BaixaMoveisEquipamento> BaixaMoveisEquipamentos { get; set; } = new List<BaixaMoveisEquipamento>();

    public virtual ICollection<CombustivelDeposito> CombustivelDepositos { get; set; } = new List<CombustivelDeposito>();

    public virtual ICollection<CombustivelEntradum> CombustivelEntrada { get; set; } = new List<CombustivelEntradum>();

    public virtual Bairro? ConBairro { get; set; }

    public virtual Cidade? ConCidade { get; set; }

    public virtual ICollection<ContribuinteFiliacao> ContribuinteFiliacaoConIdfiliacaoNavigations { get; set; } = new List<ContribuinteFiliacao>();

    public virtual ICollection<ContribuinteFiliacao> ContribuinteFiliacaoCons { get; set; } = new List<ContribuinteFiliacao>();

    public virtual ICollection<ContribuintesServidore> ContribuintesServidores { get; set; } = new List<ContribuintesServidore>();

    public virtual ICollection<DepuContrato> DepuContratos { get; set; } = new List<DepuContrato>();

    public virtual ICollection<EduformacaoContribuinte> EduformacaoContribuintes { get; set; } = new List<EduformacaoContribuinte>();

    public virtual ICollection<FissContribEmpresa> FissContribEmpresas { get; set; } = new List<FissContribEmpresa>();

    public virtual ICollection<FissTomadorPrestador> FissTomadorPrestadors { get; set; } = new List<FissTomadorPrestador>();

    public virtual ICollection<FzacessoOperadorEmpresa> FzacessoOperadorEmpresas { get; set; } = new List<FzacessoOperadorEmpresa>();

    public virtual ICollection<Fzanttcontrato> Fzanttcontratos { get; set; } = new List<Fzanttcontrato>();

    public virtual ICollection<FzautoInfraco> FzautoInfracos { get; set; } = new List<FzautoInfraco>();

    public virtual FzcondutoresVeicDocto? FzcondutoresVeicDocto { get; set; }

    public virtual ICollection<FzcondutoresVeiculo> FzcondutoresVeiculos { get; set; } = new List<FzcondutoresVeiculo>();

    public virtual ICollection<FzcredencialAncient> FzcredencialAncientCacondutors { get; set; } = new List<FzcredencialAncient>();

    public virtual ICollection<FzcredencialAncient> FzcredencialAncientCapermissionarios { get; set; } = new List<FzcredencialAncient>();

    public virtual ICollection<Fzcredencial> FzcredencialCons { get; set; } = new List<Fzcredencial>();

    public virtual ICollection<Fzcredencial> FzcredencialCredProprietarios { get; set; } = new List<Fzcredencial>();

    public virtual ICollection<FzcredenciamentoAte201103> FzcredenciamentoAte201103s { get; set; } = new List<FzcredenciamentoAte201103>();

    public virtual ICollection<FzpontosMov> FzpontosMovs { get; set; } = new List<FzpontosMov>();

    public virtual ICollection<Fzveiculo> FzveiculoEmprArrendataria { get; set; } = new List<Fzveiculo>();

    public virtual ICollection<Fzveiculo> FzveiculoProps { get; set; } = new List<Fzveiculo>();

    public virtual ICollection<FzveiculosMov> FzveiculosMovs { get; set; } = new List<FzveiculosMov>();

    public virtual ICollection<GrupoContribuinteConcessaoImovei> GrupoContribuinteConcessaoImoveis { get; set; } = new List<GrupoContribuinteConcessaoImovei>();

    public virtual ICollection<HabAtendimento> HabAtendimentos { get; set; } = new List<HabAtendimento>();

    public virtual ICollection<LocFilaEspera> LocFilaEsperas { get; set; } = new List<LocFilaEspera>();

    public virtual ICollection<Locacao> Locacaos { get; set; } = new List<Locacao>();

    public virtual ICollection<ManutencaoMoveisEquipamento> ManutencaoMoveisEquipamentos { get; set; } = new List<ManutencaoMoveisEquipamento>();

    public virtual ICollection<ManutencaoVeiculo> ManutencaoVeiculos { get; set; } = new List<ManutencaoVeiculo>();

    public virtual ICollection<OuvidoriaProcesso> OuvidoriaProcessos { get; set; } = new List<OuvidoriaProcesso>();

    public virtual ICollection<Processo> Processos { get; set; } = new List<Processo>();

    public virtual ICollection<ProdRurNotaFiscal> ProdRurNotaFiscalConIdcompradorNavigations { get; set; } = new List<ProdRurNotaFiscal>();

    public virtual ICollection<ProdRurNotaFiscal> ProdRurNotaFiscalConIdtransportadorNavigations { get; set; } = new List<ProdRurNotaFiscal>();

    public virtual ICollection<ProdRurProdutorFamilium> ProdRurProdutorFamilia { get; set; } = new List<ProdRurProdutorFamilium>();

    public virtual ICollection<ProdRurProdutor> ProdRurProdutors { get; set; } = new List<ProdRurProdutor>();

    public virtual ICollection<Psiusuario> Psiusuarios { get; set; } = new List<Psiusuario>();

    public virtual ICollection<RhdadosPessoai> RhdadosPessoais { get; set; } = new List<RhdadosPessoai>();

    public virtual ICollection<Seguro> Seguros { get; set; } = new List<Seguro>();

    public virtual ICollection<SerIturContribAtrativosTuristico> SerIturContribAtrativosTuristicos { get; set; } = new List<SerIturContribAtrativosTuristico>();

    public virtual ICollection<SocComposicaoPasse> SocComposicaoPasses { get; set; } = new List<SocComposicaoPasse>();

    public virtual ICollection<SocOcorrencium> SocOcorrencia { get; set; } = new List<SocOcorrencium>();

    public virtual ICollection<TribAlvaraConstrucaoContribuinte> TribAlvaraConstrucaoContribuintes { get; set; } = new List<TribAlvaraConstrucaoContribuinte>();

    public virtual ICollection<TribAlvaraTermoDispenca> TribAlvaraTermoDispencas { get; set; } = new List<TribAlvaraTermoDispenca>();

    public virtual ICollection<TribAutorizacaoBlocosNf> TribAutorizacaoBlocosNfConIdgraficaNavigations { get; set; } = new List<TribAutorizacaoBlocosNf>();

    public virtual ICollection<TribAutorizacaoBlocosNf> TribAutorizacaoBlocosNfCons { get; set; } = new List<TribAutorizacaoBlocosNf>();

    public virtual ICollection<TribAutosInfracao> TribAutosInfracaos { get; set; } = new List<TribAutosInfracao>();

    public virtual ICollection<TribBaixaDevolucao> TribBaixaDevolucaos { get; set; } = new List<TribBaixaDevolucao>();

    public virtual ICollection<TribCmedificacaoProcesso> TribCmedificacaoProcessos { get; set; } = new List<TribCmedificacaoProcesso>();

    public virtual ICollection<TribContador> TribContadors { get; set; } = new List<TribContador>();

    public virtual ICollection<TribContribCategProf> TribContribCategProfs { get; set; } = new List<TribContribCategProf>();

    public virtual ICollection<TribDividasContribuinte> TribDividasContribuintes { get; set; } = new List<TribDividasContribuinte>();

    public virtual ICollection<TribEdificacoesContrib> TribEdificacoesContribs { get; set; } = new List<TribEdificacoesContrib>();

    public virtual ICollection<TribEdificacoesEndereco> TribEdificacoesEnderecos { get; set; } = new List<TribEdificacoesEndereco>();

    public virtual ICollection<TribEditalComprasContribuinte> TribEditalComprasContribuintes { get; set; } = new List<TribEditalComprasContribuinte>();

    public virtual ICollection<TribEmpresa> TribEmpresas { get; set; } = new List<TribEmpresa>();

    public virtual ICollection<TribEmpresasSociosProfissionai> TribEmpresasSociosProfissionais { get; set; } = new List<TribEmpresasSociosProfissionai>();

    public virtual ICollection<TribFiscReclamaco> TribFiscReclamacos { get; set; } = new List<TribFiscReclamaco>();

    public virtual ICollection<TribItbicompradore> TribItbicompradores { get; set; } = new List<TribItbicompradore>();

    public virtual ICollection<TribItbiexCompradore> TribItbiexCompradores { get; set; } = new List<TribItbiexCompradore>();

    public virtual ICollection<TribItbiexVendedore> TribItbiexVendedores { get; set; } = new List<TribItbiexVendedore>();

    public virtual ICollection<TribItbi> TribItbis { get; set; } = new List<TribItbi>();

    public virtual ICollection<TribItbivendedore> TribItbivendedores { get; set; } = new List<TribItbivendedore>();

    public virtual ICollection<TribProtestoLoteCdacontrib> TribProtestoLoteCdacontribs { get; set; } = new List<TribProtestoLoteCdacontrib>();

    public virtual ICollection<TribProtocoloAlteracao> TribProtocoloAlteracaos { get; set; } = new List<TribProtocoloAlteracao>();

    public virtual ICollection<TribTap> TribTapConIddestinoNavigations { get; set; } = new List<TribTap>();

    public virtual ICollection<TribTap> TribTapCons { get; set; } = new List<TribTap>();

    public virtual ICollection<TribTapInscrOrigem> TribTapInscrOrigems { get; set; } = new List<TribTapInscrOrigem>();

    public virtual ICollection<TribTransfDivida> TribTransfDividaConIddestinoNavigations { get; set; } = new List<TribTransfDivida>();

    public virtual ICollection<TribTransfDivida> TribTransfDividaConIdorigemNavigations { get; set; } = new List<TribTransfDivida>();

    public virtual ICollection<TribTransfDividasContribuinte> TribTransfDividasContribuintes { get; set; } = new List<TribTransfDividasContribuinte>();

    public virtual ICollection<TribTransferencia> TribTransferenciaDeCons { get; set; } = new List<TribTransferencia>();

    public virtual ICollection<TribTransferencia> TribTransferenciaParaCons { get; set; } = new List<TribTransferencia>();

    public virtual ICollection<VeiculosBaixado> VeiculosBaixados { get; set; } = new List<VeiculosBaixado>();

    public virtual ICollection<Edudisciplina> Discs { get; set; } = new List<Edudisciplina>();

    public virtual ICollection<TribProcPeticao> ProcPets { get; set; } = new List<TribProcPeticao>();
}

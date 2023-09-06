using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Contribuinte
    {
        public Contribuinte()
        {
            Acessorios = new HashSet<Acessorio>();
            AcessoriosMoveisEquipamentos = new HashSet<AcessoriosMoveisEquipamento>();
            AgeAgendamentos = new HashSet<AgeAgendamento>();
            AguaReqSolicitacaoServicos = new HashSet<AguaReqSolicitacaoServico>();
            AlmEntrada = new HashSet<AlmEntrada>();
            BaixaImoveisImobens = new HashSet<BaixaImoveisImoben>();
            BaixaMoveisEquipamentos = new HashSet<BaixaMoveisEquipamento>();
            CombustivelDepositos = new HashSet<CombustivelDeposito>();
            CombustivelEntrada = new HashSet<CombustivelEntradum>();
            ContribuinteFiliacaoConIdfiliacaoNavigations = new HashSet<ContribuinteFiliacao>();
            ContribuinteFiliacaoCons = new HashSet<ContribuinteFiliacao>();
            ContribuintesServidores = new HashSet<ContribuintesServidore>();
            DepuContratos = new HashSet<DepuContrato>();
            EduformacaoContribuintes = new HashSet<EduformacaoContribuinte>();
            FissContribEmpresas = new HashSet<FissContribEmpresa>();
            FissTomadorPrestadors = new HashSet<FissTomadorPrestador>();
            FzacessoOperadorEmpresas = new HashSet<FzacessoOperadorEmpresa>();
            Fzanttcontratos = new HashSet<Fzanttcontrato>();
            FzautoInfracos = new HashSet<FzautoInfraco>();
            FzcondutoresVeiculos = new HashSet<FzcondutoresVeiculo>();
            FzcredencialAncientCacondutors = new HashSet<FzcredencialAncient>();
            FzcredencialAncientCapermissionarios = new HashSet<FzcredencialAncient>();
            FzcredencialCons = new HashSet<Fzcredencial>();
            FzcredencialCredProprietarios = new HashSet<Fzcredencial>();
            FzcredenciamentoAte201103s = new HashSet<FzcredenciamentoAte201103>();
            FzpontosMovs = new HashSet<FzpontosMov>();
            FzveiculoEmprArrendataria = new HashSet<Fzveiculo>();
            FzveiculoProps = new HashSet<Fzveiculo>();
            FzveiculosMovs = new HashSet<FzveiculosMov>();
            GrupoContribuinteConcessaoImoveis = new HashSet<GrupoContribuinteConcessaoImovei>();
            HabAtendimentos = new HashSet<HabAtendimento>();
            LocFilaEsperas = new HashSet<LocFilaEspera>();
            Locacaos = new HashSet<Locacao>();
            ManutencaoMoveisEquipamentos = new HashSet<ManutencaoMoveisEquipamento>();
            ManutencaoVeiculos = new HashSet<ManutencaoVeiculo>();
            OuvidoriaProcessos = new HashSet<OuvidoriaProcesso>();
            Processos = new HashSet<Processo>();
            ProdRurNotaFiscalConIdcompradorNavigations = new HashSet<ProdRurNotaFiscal>();
            ProdRurNotaFiscalConIdtransportadorNavigations = new HashSet<ProdRurNotaFiscal>();
            ProdRurProdutorFamilia = new HashSet<ProdRurProdutorFamilium>();
            ProdRurProdutors = new HashSet<ProdRurProdutor>();
            Psiusuarios = new HashSet<Psiusuario>();
            RhdadosPessoais = new HashSet<RhdadosPessoai>();
            Seguros = new HashSet<Seguro>();
            SerIturContribAtrativosTuristicos = new HashSet<SerIturContribAtrativosTuristico>();
            SocComposicaoPasses = new HashSet<SocComposicaoPasse>();
            SocOcorrencia = new HashSet<SocOcorrencium>();
            TribAlvaraConstrucaoContribuintes = new HashSet<TribAlvaraConstrucaoContribuinte>();
            TribAlvaraTermoDispencas = new HashSet<TribAlvaraTermoDispenca>();
            TribAutorizacaoBlocosNfConIdgraficaNavigations = new HashSet<TribAutorizacaoBlocosNf>();
            TribAutorizacaoBlocosNfCons = new HashSet<TribAutorizacaoBlocosNf>();
            TribAutosInfracaos = new HashSet<TribAutosInfracao>();
            TribBaixaDevolucaos = new HashSet<TribBaixaDevolucao>();
            TribCmedificacaoProcessos = new HashSet<TribCmedificacaoProcesso>();
            TribContadors = new HashSet<TribContador>();
            TribContribCategProfs = new HashSet<TribContribCategProf>();
            TribDividasContribuintes = new HashSet<TribDividasContribuinte>();
            TribEdificacoesContribs = new HashSet<TribEdificacoesContrib>();
            TribEdificacoesEnderecos = new HashSet<TribEdificacoesEndereco>();
            TribEditalComprasContribuintes = new HashSet<TribEditalComprasContribuinte>();
            TribEmpresas = new HashSet<TribEmpresa>();
            TribEmpresasSociosProfissionais = new HashSet<TribEmpresasSociosProfissionai>();
            TribFiscReclamacos = new HashSet<TribFiscReclamaco>();
            TribItbicompradores = new HashSet<TribItbicompradore>();
            TribItbiexCompradores = new HashSet<TribItbiexCompradore>();
            TribItbiexVendedores = new HashSet<TribItbiexVendedore>();
            TribItbis = new HashSet<TribItbi>();
            TribItbivendedores = new HashSet<TribItbivendedore>();
            TribProtestoLoteCdacontribs = new HashSet<TribProtestoLoteCdacontrib>();
            TribProtocoloAlteracaos = new HashSet<TribProtocoloAlteracao>();
            TribTapConIddestinoNavigations = new HashSet<TribTap>();
            TribTapCons = new HashSet<TribTap>();
            TribTapInscrOrigems = new HashSet<TribTapInscrOrigem>();
            TribTransfDividaConIddestinoNavigations = new HashSet<TribTransfDivida>();
            TribTransfDividaConIdorigemNavigations = new HashSet<TribTransfDivida>();
            TribTransfDividasContribuintes = new HashSet<TribTransfDividasContribuinte>();
            TribTransferenciaDeCons = new HashSet<TribTransferencia>();
            TribTransferenciaParaCons = new HashSet<TribTransferencia>();
            VeiculosBaixados = new HashSet<VeiculosBaixado>();
            Discs = new HashSet<Edudisciplina>();
            ProcPets = new HashSet<TribProcPeticao>();
        }

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

        public virtual Bairro? ConBairro { get; set; }
        public virtual Cidade? ConCidade { get; set; }
        public virtual FzcondutoresVeicDocto? FzcondutoresVeicDocto { get; set; }
        public virtual ICollection<Acessorio> Acessorios { get; set; }
        public virtual ICollection<AcessoriosMoveisEquipamento> AcessoriosMoveisEquipamentos { get; set; }
        public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; }
        public virtual ICollection<AguaReqSolicitacaoServico> AguaReqSolicitacaoServicos { get; set; }
        public virtual ICollection<AlmEntrada> AlmEntrada { get; set; }
        public virtual ICollection<BaixaImoveisImoben> BaixaImoveisImobens { get; set; }
        public virtual ICollection<BaixaMoveisEquipamento> BaixaMoveisEquipamentos { get; set; }
        public virtual ICollection<CombustivelDeposito> CombustivelDepositos { get; set; }
        public virtual ICollection<CombustivelEntradum> CombustivelEntrada { get; set; }
        public virtual ICollection<ContribuinteFiliacao> ContribuinteFiliacaoConIdfiliacaoNavigations { get; set; }
        public virtual ICollection<ContribuinteFiliacao> ContribuinteFiliacaoCons { get; set; }
        public virtual ICollection<ContribuintesServidore> ContribuintesServidores { get; set; }
        public virtual ICollection<DepuContrato> DepuContratos { get; set; }
        public virtual ICollection<EduformacaoContribuinte> EduformacaoContribuintes { get; set; }
        public virtual ICollection<FissContribEmpresa> FissContribEmpresas { get; set; }
        public virtual ICollection<FissTomadorPrestador> FissTomadorPrestadors { get; set; }
        public virtual ICollection<FzacessoOperadorEmpresa> FzacessoOperadorEmpresas { get; set; }
        public virtual ICollection<Fzanttcontrato> Fzanttcontratos { get; set; }
        public virtual ICollection<FzautoInfraco> FzautoInfracos { get; set; }
        public virtual ICollection<FzcondutoresVeiculo> FzcondutoresVeiculos { get; set; }
        public virtual ICollection<FzcredencialAncient> FzcredencialAncientCacondutors { get; set; }
        public virtual ICollection<FzcredencialAncient> FzcredencialAncientCapermissionarios { get; set; }
        public virtual ICollection<Fzcredencial> FzcredencialCons { get; set; }
        public virtual ICollection<Fzcredencial> FzcredencialCredProprietarios { get; set; }
        public virtual ICollection<FzcredenciamentoAte201103> FzcredenciamentoAte201103s { get; set; }
        public virtual ICollection<FzpontosMov> FzpontosMovs { get; set; }
        public virtual ICollection<Fzveiculo> FzveiculoEmprArrendataria { get; set; }
        public virtual ICollection<Fzveiculo> FzveiculoProps { get; set; }
        public virtual ICollection<FzveiculosMov> FzveiculosMovs { get; set; }
        public virtual ICollection<GrupoContribuinteConcessaoImovei> GrupoContribuinteConcessaoImoveis { get; set; }
        public virtual ICollection<HabAtendimento> HabAtendimentos { get; set; }
        public virtual ICollection<LocFilaEspera> LocFilaEsperas { get; set; }
        public virtual ICollection<Locacao> Locacaos { get; set; }
        public virtual ICollection<ManutencaoMoveisEquipamento> ManutencaoMoveisEquipamentos { get; set; }
        public virtual ICollection<ManutencaoVeiculo> ManutencaoVeiculos { get; set; }
        public virtual ICollection<OuvidoriaProcesso> OuvidoriaProcessos { get; set; }
        public virtual ICollection<Processo> Processos { get; set; }
        public virtual ICollection<ProdRurNotaFiscal> ProdRurNotaFiscalConIdcompradorNavigations { get; set; }
        public virtual ICollection<ProdRurNotaFiscal> ProdRurNotaFiscalConIdtransportadorNavigations { get; set; }
        public virtual ICollection<ProdRurProdutorFamilium> ProdRurProdutorFamilia { get; set; }
        public virtual ICollection<ProdRurProdutor> ProdRurProdutors { get; set; }
        public virtual ICollection<Psiusuario> Psiusuarios { get; set; }
        public virtual ICollection<RhdadosPessoai> RhdadosPessoais { get; set; }
        public virtual ICollection<Seguro> Seguros { get; set; }
        public virtual ICollection<SerIturContribAtrativosTuristico> SerIturContribAtrativosTuristicos { get; set; }
        public virtual ICollection<SocComposicaoPasse> SocComposicaoPasses { get; set; }
        public virtual ICollection<SocOcorrencium> SocOcorrencia { get; set; }
        public virtual ICollection<TribAlvaraConstrucaoContribuinte> TribAlvaraConstrucaoContribuintes { get; set; }
        public virtual ICollection<TribAlvaraTermoDispenca> TribAlvaraTermoDispencas { get; set; }
        public virtual ICollection<TribAutorizacaoBlocosNf> TribAutorizacaoBlocosNfConIdgraficaNavigations { get; set; }
        public virtual ICollection<TribAutorizacaoBlocosNf> TribAutorizacaoBlocosNfCons { get; set; }
        public virtual ICollection<TribAutosInfracao> TribAutosInfracaos { get; set; }
        public virtual ICollection<TribBaixaDevolucao> TribBaixaDevolucaos { get; set; }
        public virtual ICollection<TribCmedificacaoProcesso> TribCmedificacaoProcessos { get; set; }
        public virtual ICollection<TribContador> TribContadors { get; set; }
        public virtual ICollection<TribContribCategProf> TribContribCategProfs { get; set; }
        public virtual ICollection<TribDividasContribuinte> TribDividasContribuintes { get; set; }
        public virtual ICollection<TribEdificacoesContrib> TribEdificacoesContribs { get; set; }
        public virtual ICollection<TribEdificacoesEndereco> TribEdificacoesEnderecos { get; set; }
        public virtual ICollection<TribEditalComprasContribuinte> TribEditalComprasContribuintes { get; set; }
        public virtual ICollection<TribEmpresa> TribEmpresas { get; set; }
        public virtual ICollection<TribEmpresasSociosProfissionai> TribEmpresasSociosProfissionais { get; set; }
        public virtual ICollection<TribFiscReclamaco> TribFiscReclamacos { get; set; }
        public virtual ICollection<TribItbicompradore> TribItbicompradores { get; set; }
        public virtual ICollection<TribItbiexCompradore> TribItbiexCompradores { get; set; }
        public virtual ICollection<TribItbiexVendedore> TribItbiexVendedores { get; set; }
        public virtual ICollection<TribItbi> TribItbis { get; set; }
        public virtual ICollection<TribItbivendedore> TribItbivendedores { get; set; }
        public virtual ICollection<TribProtestoLoteCdacontrib> TribProtestoLoteCdacontribs { get; set; }
        public virtual ICollection<TribProtocoloAlteracao> TribProtocoloAlteracaos { get; set; }
        public virtual ICollection<TribTap> TribTapConIddestinoNavigations { get; set; }
        public virtual ICollection<TribTap> TribTapCons { get; set; }
        public virtual ICollection<TribTapInscrOrigem> TribTapInscrOrigems { get; set; }
        public virtual ICollection<TribTransfDivida> TribTransfDividaConIddestinoNavigations { get; set; }
        public virtual ICollection<TribTransfDivida> TribTransfDividaConIdorigemNavigations { get; set; }
        public virtual ICollection<TribTransfDividasContribuinte> TribTransfDividasContribuintes { get; set; }
        public virtual ICollection<TribTransferencia> TribTransferenciaDeCons { get; set; }
        public virtual ICollection<TribTransferencia> TribTransferenciaParaCons { get; set; }
        public virtual ICollection<VeiculosBaixado> VeiculosBaixados { get; set; }

        public virtual ICollection<Edudisciplina> Discs { get; set; }
        public virtual ICollection<TribProcPeticao> ProcPets { get; set; }
    }
}

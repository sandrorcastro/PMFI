using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresa
    {
        public NfseTblEmpresa()
        {
            NfseTblClientes = new HashSet<NfseTblCliente>();
            NfseTblConta = new HashSet<NfseTblContum>();
            NfseTblCredenciamentos = new HashSet<NfseTblCredenciamento>();
            NfseTblDeclaracaoPendentes = new HashSet<NfseTblDeclaracaoPendente>();
            NfseTblDeclaracaoSemIncidencia = new HashSet<NfseTblDeclaracaoSemIncidencium>();
            NfseTblDeclaracaoSemMovimentos = new HashSet<NfseTblDeclaracaoSemMovimento>();
            NfseTblEmpresaCnaes = new HashSet<NfseTblEmpresaCnae>();
            NfseTblEmpresaContratos = new HashSet<NfseTblEmpresaContrato>();
            NfseTblEmpresaNaturezaOperacos = new HashSet<NfseTblEmpresaNaturezaOperaco>();
            NfseTblEmpresaPerfils = new HashSet<NfseTblEmpresaPerfil>();
            NfseTblEmpresaServicoDeducaos = new HashSet<NfseTblEmpresaServicoDeducao>();
            NfseTblEmpresaServicos = new HashSet<NfseTblEmpresaServico>();
            NfseTblEmpresaSubstitutoHistoricos = new HashSet<NfseTblEmpresaSubstitutoHistorico>();
            NfseTblEmpresaTipoTomadores = new HashSet<NfseTblEmpresaTipoTomadore>();
            NfseTblEncerramentos = new HashSet<NfseTblEncerramento>();
            NfseTblErroSemMovimentos = new HashSet<NfseTblErroSemMovimento>();
            NfseTblHomologacaos = new HashSet<NfseTblHomologacao>();
            NfseTblLogAcaos = new HashSet<NfseTblLogAcao>();
            NfseTblLogs = new HashSet<NfseTblLog>();
            NfseTblNfseNums = new HashSet<NfseTblNfseNum>();
            NfseTblPedAlteraRegimes = new HashSet<NfseTblPedAlteraRegime>();
            NfseTblRpsImpressos = new HashSet<NfseTblRpsImpresso>();
        }

        public int Idempresa { get; set; }
        public int? Idcontribuinte { get; set; }
        public string? Stsituacao { get; set; }
        public string? Stcrc { get; set; }
        public byte? Idregime { get; set; }
        public string? Stsubtributario { get; set; }
        public string? Sttptributacao { get; set; }
        public string? Stoptsimnac { get; set; }
        public string? Stpejudipu { get; set; }
        public int? Idempresamatriz { get; set; }
        public DateTime? Dtabertura { get; set; }
        public string? Nuprocabertura { get; set; }
        public string? Stcontadorcpfcnpj { get; set; }
        public string? Stcontadorend { get; set; }
        public string? Stcontadortel { get; set; }
        public string? Stcontadornome { get; set; }
        public DateTime? Dtadesaosubstituto { get; set; }
        public string? Stobrigarecad { get; set; }

        public virtual NfseTblContribuinte? IdcontribuinteNavigation { get; set; }
        public virtual ICollection<NfseTblCliente> NfseTblClientes { get; set; }
        public virtual ICollection<NfseTblContum> NfseTblConta { get; set; }
        public virtual ICollection<NfseTblCredenciamento> NfseTblCredenciamentos { get; set; }
        public virtual ICollection<NfseTblDeclaracaoPendente> NfseTblDeclaracaoPendentes { get; set; }
        public virtual ICollection<NfseTblDeclaracaoSemIncidencium> NfseTblDeclaracaoSemIncidencia { get; set; }
        public virtual ICollection<NfseTblDeclaracaoSemMovimento> NfseTblDeclaracaoSemMovimentos { get; set; }
        public virtual ICollection<NfseTblEmpresaCnae> NfseTblEmpresaCnaes { get; set; }
        public virtual ICollection<NfseTblEmpresaContrato> NfseTblEmpresaContratos { get; set; }
        public virtual ICollection<NfseTblEmpresaNaturezaOperaco> NfseTblEmpresaNaturezaOperacos { get; set; }
        public virtual ICollection<NfseTblEmpresaPerfil> NfseTblEmpresaPerfils { get; set; }
        public virtual ICollection<NfseTblEmpresaServicoDeducao> NfseTblEmpresaServicoDeducaos { get; set; }
        public virtual ICollection<NfseTblEmpresaServico> NfseTblEmpresaServicos { get; set; }
        public virtual ICollection<NfseTblEmpresaSubstitutoHistorico> NfseTblEmpresaSubstitutoHistoricos { get; set; }
        public virtual ICollection<NfseTblEmpresaTipoTomadore> NfseTblEmpresaTipoTomadores { get; set; }
        public virtual ICollection<NfseTblEncerramento> NfseTblEncerramentos { get; set; }
        public virtual ICollection<NfseTblErroSemMovimento> NfseTblErroSemMovimentos { get; set; }
        public virtual ICollection<NfseTblHomologacao> NfseTblHomologacaos { get; set; }
        public virtual ICollection<NfseTblLogAcao> NfseTblLogAcaos { get; set; }
        public virtual ICollection<NfseTblLog> NfseTblLogs { get; set; }
        public virtual ICollection<NfseTblNfseNum> NfseTblNfseNums { get; set; }
        public virtual ICollection<NfseTblPedAlteraRegime> NfseTblPedAlteraRegimes { get; set; }
        public virtual ICollection<NfseTblRpsImpresso> NfseTblRpsImpressos { get; set; }
    }
}

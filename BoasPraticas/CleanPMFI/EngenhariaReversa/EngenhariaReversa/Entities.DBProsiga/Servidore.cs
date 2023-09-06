using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Servidore
    {
        public Servidore()
        {
            AgeAgenda = new HashSet<AgeAgendum>();
            AgeAgendamentos = new HashSet<AgeAgendamento>();
            AgePermissaos = new HashSet<AgePermissao>();
            CombustivelSaidumServIdOperarioNavigations = new HashSet<CombustivelSaidum>();
            CombustivelSaidumServs = new HashSet<CombustivelSaidum>();
            FissContribEmpresas = new HashSet<FissContribEmpresa>();
            FissDespachosServidores = new HashSet<FissDespachosServidore>();
            Processos = new HashSet<Processo>();
            Recebimentos = new HashSet<Recebimento>();
            SaudeServidorCategProfs = new HashSet<SaudeServidorCategProf>();
            TribFiscFiscais = new HashSet<TribFiscFiscai>();
            TribPortalMensagems = new HashSet<TribPortalMensagem>();
            Usuarios = new HashSet<Usuario>();
            VeicSolicitacaos = new HashSet<VeicSolicitacao>();
            XFrotaOrdensServicos = new HashSet<XFrotaOrdensServico>();
            CertidaoDa = new HashSet<TribCertidaoDum>();
            IdDepVals = new HashSet<TbDeprecicaoValorizacao>();
        }

        public long ServId { get; set; }
        public string? ServNome { get; set; }
        public string? ServCargo { get; set; }
        public string? ServFuncao { get; set; }
        public int? ServDivisaoId { get; set; }
        public string? ServRg { get; set; }
        /// <summary>
        /// Número de Matricula do servidor na empresa
        /// </summary>
        public long? ServMatricula { get; set; }
        /// <summary>
        /// Situação Funcional do Servidor, podendo ser Inativo, Pensionista, Licenca Saude, Ferias, etc
        /// </summary>
        public string? ServSituacaoFunc { get; set; }
        public int? IdEndereco { get; set; }
        public string? NuPredial { get; set; }
        public string? Complemento { get; set; }
        public string? ServTelefone { get; set; }
        public string? ServEmail { get; set; }
        public byte[]? ImgAssinatura { get; set; }

        public virtual ICollection<AgeAgendum> AgeAgenda { get; set; }
        public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; }
        public virtual ICollection<AgePermissao> AgePermissaos { get; set; }
        public virtual ICollection<CombustivelSaidum> CombustivelSaidumServIdOperarioNavigations { get; set; }
        public virtual ICollection<CombustivelSaidum> CombustivelSaidumServs { get; set; }
        public virtual ICollection<FissContribEmpresa> FissContribEmpresas { get; set; }
        public virtual ICollection<FissDespachosServidore> FissDespachosServidores { get; set; }
        public virtual ICollection<Processo> Processos { get; set; }
        public virtual ICollection<Recebimento> Recebimentos { get; set; }
        public virtual ICollection<SaudeServidorCategProf> SaudeServidorCategProfs { get; set; }
        public virtual ICollection<TribFiscFiscai> TribFiscFiscais { get; set; }
        public virtual ICollection<TribPortalMensagem> TribPortalMensagems { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<VeicSolicitacao> VeicSolicitacaos { get; set; }
        public virtual ICollection<XFrotaOrdensServico> XFrotaOrdensServicos { get; set; }

        public virtual ICollection<TribCertidaoDum> CertidaoDa { get; set; }
        public virtual ICollection<TbDeprecicaoValorizacao> IdDepVals { get; set; }
    }
}

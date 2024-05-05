using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Servidore
{
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

    public virtual ICollection<AgeAgendum> AgeAgenda { get; set; } = new List<AgeAgendum>();

    public virtual ICollection<AgeAgendamento> AgeAgendamentos { get; set; } = new List<AgeAgendamento>();

    public virtual ICollection<AgePermissao> AgePermissaos { get; set; } = new List<AgePermissao>();

    public virtual ICollection<CombustivelSaidum> CombustivelSaidumServIdOperarioNavigations { get; set; } = new List<CombustivelSaidum>();

    public virtual ICollection<CombustivelSaidum> CombustivelSaidumServs { get; set; } = new List<CombustivelSaidum>();

    public virtual ICollection<FissContribEmpresa> FissContribEmpresas { get; set; } = new List<FissContribEmpresa>();

    public virtual ICollection<FissDespachosServidore> FissDespachosServidores { get; set; } = new List<FissDespachosServidore>();

    public virtual ICollection<Processo> Processos { get; set; } = new List<Processo>();

    public virtual ICollection<Recebimento> Recebimentos { get; set; } = new List<Recebimento>();

    public virtual ICollection<SaudeServidorCategProf> SaudeServidorCategProfs { get; set; } = new List<SaudeServidorCategProf>();

    public virtual ICollection<TribFiscFiscai> TribFiscFiscais { get; set; } = new List<TribFiscFiscai>();

    public virtual ICollection<TribPortalMensagem> TribPortalMensagems { get; set; } = new List<TribPortalMensagem>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual ICollection<VeicSolicitacao> VeicSolicitacaos { get; set; } = new List<VeicSolicitacao>();

    public virtual ICollection<XFrotaOrdensServico> XFrotaOrdensServicos { get; set; } = new List<XFrotaOrdensServico>();

    public virtual ICollection<TribCertidaoDum> CertidaoDa { get; set; } = new List<TribCertidaoDum>();

    public virtual ICollection<TbDeprecicaoValorizacao> IdDepVals { get; set; } = new List<TbDeprecicaoValorizacao>();
}

using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Usuario
{
    public string UsuId { get; set; } = null!;

    public string? UsuNivelAcesso { get; set; }

    public string? UsuAvisaGravacao { get; set; }

    public long? UsuServidorId { get; set; }

    public DateTime? UsuDtvalidade { get; set; }

    public string? UsuDistrProc { get; set; }

    public string? UsuRecProc { get; set; }

    public string? UsuArquivaReabre { get; set; }

    public string UsuAudSis { get; set; } = null!;

    /// <summary>
    /// Esse campo é utilizado para dar permissão automática para formulários cadastrados no sistema.
    /// </summary>
    public string UsuAdministrador { get; set; } = null!;

    public string? UsuEmail { get; set; }

    /// <summary>
    /// Grava Log do Sistema
    /// </summary>
    public string UsuLogger { get; set; } = null!;

    public string? UsuFone { get; set; }

    public string UsuAvisoEmailBaixa { get; set; } = null!;

    public byte[]? UsuSenha { get; set; }

    public virtual ICollection<Agendum> Agenda { get; set; } = new List<Agendum>();

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();

    public virtual ICollection<CombustivelSaidaMovimento> CombustivelSaidaMovimentos { get; set; } = new List<CombustivelSaidaMovimento>();

    public virtual ICollection<GeralLembrete> GeralLembretes { get; set; } = new List<GeralLembrete>();

    public virtual ICollection<HabAtendimento> HabAtendimentos { get; set; } = new List<HabAtendimento>();

    public virtual ICollection<HabDocApresentado> HabDocApresentados { get; set; } = new List<HabDocApresentado>();

    public virtual ICollection<HabLotesAtendimento> HabLotesAtendimentos { get; set; } = new List<HabLotesAtendimento>();

    public virtual ICollection<MembrosUsuario> MembrosUsuarios { get; set; } = new List<MembrosUsuario>();

    public virtual ICollection<Permisso> Permissos { get; set; } = new List<Permisso>();

    public virtual ICollection<PortalPermissoesPagina> PortalPermissoesPaginas { get; set; } = new List<PortalPermissoesPagina>();

    public virtual ICollection<PortalPublicaco> PortalPublicacos { get; set; } = new List<PortalPublicaco>();

    public virtual ICollection<ProdRurNotaFiscalOcorr> ProdRurNotaFiscalOcorrs { get; set; } = new List<ProdRurNotaFiscalOcorr>();

    public virtual ICollection<SaudeUsuariosUnidade> SaudeUsuariosUnidades { get; set; } = new List<SaudeUsuariosUnidade>();

    public virtual ICollection<SisAtalho> SisAtalhos { get; set; } = new List<SisAtalho>();

    public virtual ICollection<SisOcorrencia> SisOcorrencia { get; set; } = new List<SisOcorrencia>();

    public virtual ICollection<SisTarefaAgendum> SisTarefaAgenda { get; set; } = new List<SisTarefaAgendum>();

    public virtual ICollection<TbImoMovimentoObra> TbImoMovimentoObras { get; set; } = new List<TbImoMovimentoObra>();

    public virtual Servidore? UsuServidor { get; set; }

    public virtual ICollection<WflowAnexo> WflowAnexos { get; set; } = new List<WflowAnexo>();

    public virtual ICollection<WflowDespachoFluxo> WflowDespachoFluxos { get; set; } = new List<WflowDespachoFluxo>();

    public virtual ICollection<Almoxarifado> Almoxes { get; set; } = new List<Almoxarifado>();

    public virtual ICollection<Diviso> DivAutDivisaos { get; set; } = new List<Diviso>();

    public virtual ICollection<SaudeEstoque> IdEstoques { get; set; } = new List<SaudeEstoque>();

    public virtual ICollection<Modulo> Mods { get; set; } = new List<Modulo>();

    public virtual ICollection<SisTarefa> TiJos { get; set; } = new List<SisTarefa>();

    public virtual ICollection<TribTipoTributo> TipoTribs { get; set; } = new List<TribTipoTributo>();
}

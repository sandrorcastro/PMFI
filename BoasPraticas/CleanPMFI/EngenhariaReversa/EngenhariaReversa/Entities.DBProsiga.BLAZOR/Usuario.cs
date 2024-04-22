using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Usuario
    {
        public Usuario()
        {
            Agenda = new HashSet<Agendum>();
            Chats = new HashSet<Chat>();
            CombustivelSaidaMovimentos = new HashSet<CombustivelSaidaMovimento>();
            GeralLembretes = new HashSet<GeralLembrete>();
            HabAtendimentos = new HashSet<HabAtendimento>();
            HabDocApresentados = new HashSet<HabDocApresentado>();
            HabLotesAtendimentos = new HashSet<HabLotesAtendimento>();
            MembrosUsuarios = new HashSet<MembrosUsuario>();
            Permissos = new HashSet<Permisso>();
            PortalPermissoesPaginas = new HashSet<PortalPermissoesPagina>();
            PortalPublicacos = new HashSet<PortalPublicaco>();
            ProdRurNotaFiscalOcorrs = new HashSet<ProdRurNotaFiscalOcorr>();
            SaudeUsuariosUnidades = new HashSet<SaudeUsuariosUnidade>();
            SisAtalhos = new HashSet<SisAtalho>();
            SisOcorrencia = new HashSet<SisOcorrencia>();
            SisTarefaAgenda = new HashSet<SisTarefaAgendum>();
            TbImoMovimentoObras = new HashSet<TbImoMovimentoObra>();
            WflowAnexos = new HashSet<WflowAnexo>();
            WflowDespachoFluxos = new HashSet<WflowDespachoFluxo>();
            Almoxes = new HashSet<Almoxarifado>();
            DivAutDivisaos = new HashSet<Diviso>();
            IdEstoques = new HashSet<SaudeEstoque>();
            Mods = new HashSet<Modulo>();
            TiJos = new HashSet<SisTarefa>();
            TipoTribs = new HashSet<TribTipoTributo>();
        }

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

        public virtual Servidore? UsuServidor { get; set; }
        public virtual ICollection<Agendum> Agenda { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<CombustivelSaidaMovimento> CombustivelSaidaMovimentos { get; set; }
        public virtual ICollection<GeralLembrete> GeralLembretes { get; set; }
        public virtual ICollection<HabAtendimento> HabAtendimentos { get; set; }
        public virtual ICollection<HabDocApresentado> HabDocApresentados { get; set; }
        public virtual ICollection<HabLotesAtendimento> HabLotesAtendimentos { get; set; }
        public virtual ICollection<MembrosUsuario> MembrosUsuarios { get; set; }
        public virtual ICollection<Permisso> Permissos { get; set; }
        public virtual ICollection<PortalPermissoesPagina> PortalPermissoesPaginas { get; set; }
        public virtual ICollection<PortalPublicaco> PortalPublicacos { get; set; }
        public virtual ICollection<ProdRurNotaFiscalOcorr> ProdRurNotaFiscalOcorrs { get; set; }
        public virtual ICollection<SaudeUsuariosUnidade> SaudeUsuariosUnidades { get; set; }
        public virtual ICollection<SisAtalho> SisAtalhos { get; set; }
        public virtual ICollection<SisOcorrencia> SisOcorrencia { get; set; }
        public virtual ICollection<SisTarefaAgendum> SisTarefaAgenda { get; set; }
        public virtual ICollection<TbImoMovimentoObra> TbImoMovimentoObras { get; set; }
        public virtual ICollection<WflowAnexo> WflowAnexos { get; set; }
        public virtual ICollection<WflowDespachoFluxo> WflowDespachoFluxos { get; set; }

        public virtual ICollection<Almoxarifado> Almoxes { get; set; }
        public virtual ICollection<Diviso> DivAutDivisaos { get; set; }
        public virtual ICollection<SaudeEstoque> IdEstoques { get; set; }
        public virtual ICollection<Modulo> Mods { get; set; }
        public virtual ICollection<SisTarefa> TiJos { get; set; }
        public virtual ICollection<TribTipoTributo> TipoTribs { get; set; }
    }
}

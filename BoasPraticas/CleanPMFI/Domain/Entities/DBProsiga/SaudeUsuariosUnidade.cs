using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeUsuariosUnidade
    {
        public SaudeUsuariosUnidade()
        {
            SaudeAutorizaFormularios = new HashSet<SaudeAutorizaFormulario>();
        }

        public int IdLogonAutorizado { get; set; }
        public string UsuId { get; set; } = null!;
        public string? UnidadePadrao { get; set; }

        public virtual SaudeAutorizaAcesso IdLogonAutorizadoNavigation { get; set; } = null!;
        public virtual Usuario Usu { get; set; } = null!;
        public virtual ICollection<SaudeAutorizaFormulario> SaudeAutorizaFormularios { get; set; }
    }
}

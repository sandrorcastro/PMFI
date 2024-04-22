using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeAutorizaAcesso
    {
        public SaudeAutorizaAcesso()
        {
            SaudeUsuariosUnidades = new HashSet<SaudeUsuariosUnidade>();
        }

        public int IdLogonAutorizado { get; set; }
        public string? TipoOrgao { get; set; }
        public int? IdLaboratorio { get; set; }
        public int? IdUnidadeSaude { get; set; }

        public virtual UnidadeSaude? IdUnidadeSaudeNavigation { get; set; }
        public virtual ICollection<SaudeUsuariosUnidade> SaudeUsuariosUnidades { get; set; }
    }
}

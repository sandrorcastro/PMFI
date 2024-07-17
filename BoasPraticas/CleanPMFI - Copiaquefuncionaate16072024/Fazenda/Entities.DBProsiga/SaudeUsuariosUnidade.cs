using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeUsuariosUnidade
{
    public int IdLogonAutorizado { get; set; }

    public string UsuId { get; set; } = null!;

    public string? UnidadePadrao { get; set; }

    public virtual SaudeAutorizaAcesso IdLogonAutorizadoNavigation { get; set; } = null!;

    public virtual ICollection<SaudeAutorizaFormulario> SaudeAutorizaFormularios { get; set; } = new List<SaudeAutorizaFormulario>();

    public virtual Usuario Usu { get; set; } = null!;
}

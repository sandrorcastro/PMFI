using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Formulario
{
    public string FrmId { get; set; } = null!;

    public string FrmTipo { get; set; } = null!;

    public string? FrmNome { get; set; }

    public int? FrmIdGrupoServico { get; set; }

    public string? FrmDescr { get; set; }

    public string? FrmPublicaIntranet { get; set; }

    public string? FrmEnderecoForm { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? FrmChecaPermissao { get; set; }

    /// <summary>
    /// Indica se o formulário está em manutenção bloqueando o acesso a ele
    /// </summary>
    public string? FrmEmManutencao { get; set; }

    public string? FrmIntegradoProSiga { get; set; }

    public string? FrmIntegradoxFrota { get; set; }

    public string? FrmIntegradoImobens { get; set; }

    public string? FrmIntegradoLocar { get; set; }

    public string? FrmIntegradoTribunoNet { get; set; }

    public string? FrmIntegradoxMoveis { get; set; }

    public string? FrmIntegradoAdmAcesso { get; set; }

    public string? FrmIntegradoGcc { get; set; }

    public string? FrmIntegradoControleVt { get; set; }

    public bool? FrmFlSuspenso { get; set; }

    public string? FrmDsClassIcone { get; set; }

    public virtual GruposServico? FrmIdGrupoServicoNavigation { get; set; }

    public virtual ICollection<Permisso> Permissos { get; set; } = new List<Permisso>();

    public virtual ICollection<SaudeAutorizaFormulario> SaudeAutorizaFormularios { get; set; } = new List<SaudeAutorizaFormulario>();

    public virtual ICollection<SisAtalho> SisAtalhoFormIdatalhoNavigations { get; set; } = new List<SisAtalho>();

    public virtual ICollection<SisAtalho> SisAtalhoFormIdlocalNavigations { get; set; } = new List<SisAtalho>();

    public virtual ICollection<Modulo> Mods { get; set; } = new List<Modulo>();
}

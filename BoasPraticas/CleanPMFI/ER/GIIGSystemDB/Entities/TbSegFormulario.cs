using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegFormulario
{
    public short IdForm { get; set; }

    public short? IdFormTipo { get; set; }

    public short? IdGrupoServico { get; set; }

    public short? IdModulo { get; set; }

    public string? NmArquivo { get; set; }

    public string? NmForm { get; set; }

    public string? DsForm { get; set; }

    public string? DsEnderecoForm { get; set; }

    public string? FlChecaPermissao { get; set; }

    /// <summary>
    /// Indica se o formulário está em manutenção bloqueando o acesso a ele
    /// </summary>
    public string? FlEmManutencao { get; set; }

    public string DsLoginInclusao { get; set; } = null!;

    public DateTime? DtInclusao { get; set; }

    public virtual TbSegFormularioTipo? IdFormTipoNavigation { get; set; }

    public virtual TbSegGruposServico? IdGrupoServicoNavigation { get; set; }

    public virtual TbSegModulo? IdModuloNavigation { get; set; }

    public virtual ICollection<TbSegPerfisdeAcessoFormulario> TbSegPerfisdeAcessoFormularios { get; set; } = new List<TbSegPerfisdeAcessoFormulario>();
}

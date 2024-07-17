using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TmptbOrcReceita
{
    public int IdReceita { get; set; }

    public short? IdEmpresa { get; set; }

    public short NrAno { get; set; }

    public string? CdReceita { get; set; }

    public string? DsReceita { get; set; }

    public string? DsEspecificacao { get; set; }

    public string? FlReceitaPadrao { get; set; }

    public string? DsTipoReceitaPadrao { get; set; }

    public DateTime? DtCadastro { get; set; }

    public DateTime? DtDesativacao { get; set; }

    public int? IdReceitaNivelSuper { get; set; }

    public string? FlReceitaIntraOrcamentaria { get; set; }

    public short? IdTipoPermissaoDeducao { get; set; }

    public short? IdTipoNivelContaNumerico { get; set; }

    public short? IdTipoEsferaGoverno { get; set; }

    public string? Observacao { get; set; }
}

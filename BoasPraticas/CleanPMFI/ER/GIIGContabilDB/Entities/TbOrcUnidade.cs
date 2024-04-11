using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcUnidade
{
    public short Idempresa { get; set; }

    public short NrAno { get; set; }

    public string CdOrgao { get; set; } = null!;

    public string CdUnidade { get; set; } = null!;

    public string? NmUnidade { get; set; }

    public string? DsSigla { get; set; }

    public DateTime? DtExtincao { get; set; }

    public short? IdEmpresaExecutora { get; set; }

    public string? FlIntraOrcamentaria { get; set; }

    public string? DsTitulosNotasDespesa { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsEmailNotificacao { get; set; }

    public DateTime? DtInicioVigenciaCnpj { get; set; }

    public virtual ICollection<TbCntOrgaosUnidadesVinculada> TbCntOrgaosUnidadesVinculada { get; set; } = new List<TbCntOrgaosUnidadesVinculada>();

    public virtual ICollection<TbDspSetoresCompraOrgaosUnidade> TbDspSetoresCompraOrgaosUnidades { get; set; } = new List<TbDspSetoresCompraOrgaosUnidade>();

    public virtual TbOrcOrgao TbOrcOrgao { get; set; } = null!;
}

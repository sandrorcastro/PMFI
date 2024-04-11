using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicDoctosCrcf
{
    public short IdDocCrcf { get; set; }

    public string? NmDocCrcf { get; set; }

    public string? FlDocInibeEmissaoCrcf { get; set; }

    public string? DsTipoDocumento { get; set; }

    public string? DsCategoria { get; set; }

    public short? CdTc { get; set; }

    public int? IdPessoa { get; set; }

    public virtual ICollection<TbLicDoctosApresentado> TbLicDoctosApresentados { get; set; } = new List<TbLicDoctosApresentado>();

    public virtual ICollection<TbGerCategoriasPessoa> IdCategoria { get; set; } = new List<TbGerCategoriasPessoa>();

    public virtual ICollection<TbLicTipoCrcf> IdTipoCrcfs { get; set; } = new List<TbLicTipoCrcf>();
}

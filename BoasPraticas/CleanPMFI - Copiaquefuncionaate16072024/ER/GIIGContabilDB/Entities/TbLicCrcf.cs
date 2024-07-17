using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicCrcf
{
    public int IdCrcf { get; set; }

    public short? IdEmpresa { get; set; }

    public short? IdTipoCrcf { get; set; }

    public int? IdPessoa { get; set; }

    public int? NrCrcf { get; set; }

    public string? NrProcesso { get; set; }

    public DateTime? DtEmissao { get; set; }

    public DateTime? DtValidade { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsTexto { get; set; }

    public string? DsObservacao { get; set; }

    public virtual ICollection<TbLicDoctosApresentado> IdDocApresentados { get; set; } = new List<TbLicDoctosApresentado>();
}

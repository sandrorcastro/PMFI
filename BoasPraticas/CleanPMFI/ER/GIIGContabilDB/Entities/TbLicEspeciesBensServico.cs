using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicEspeciesBensServico
{
    public short IdBemServico { get; set; }

    public string? CdBemServico { get; set; }

    public string? DsBemServico { get; set; }

    public string? FlPermiteEmpenhoDireto { get; set; }

    public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; } = new List<TbLicLicitaco>();
}

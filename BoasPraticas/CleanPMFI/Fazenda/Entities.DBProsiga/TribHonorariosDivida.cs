using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribHonorariosDivida
{
    public int HonorarioDivId { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public int? HonorarioId { get; set; }

    public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }

    public virtual TribDividasEmpresa? DivEmp { get; set; }

    public virtual TribDividasImo? ImoIddividaNavigation { get; set; }

    public virtual ICollection<TribHonorariosCdum> TribHonorariosCda { get; set; } = new List<TribHonorariosCdum>();

    public virtual ICollection<TribHonorariosSemCdum> TribHonorariosSemCda { get; set; } = new List<TribHonorariosSemCdum>();
}

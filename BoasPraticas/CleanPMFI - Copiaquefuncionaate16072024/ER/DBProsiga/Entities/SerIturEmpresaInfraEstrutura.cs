using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SerIturEmpresaInfraEstrutura
{
    public int EmprInfraId { get; set; }

    public string? EmprInfraNome { get; set; }

    public int? TipoInfraEstId { get; set; }

    public long? EmprCmc { get; set; }

    public int? TipoEstabId { get; set; }

    public long? EmprId { get; set; }

    public virtual TribEmpresa? EmprCmcNavigation { get; set; }

    public virtual ICollection<SerIturEmpresaServicosEquipamento> SerIturEmpresaServicosEquipamentos { get; set; } = new List<SerIturEmpresaServicosEquipamento>();

    public virtual SerIturTipoEstabelecimento? TipoEstab { get; set; }

    public virtual SerIturTipoInfraEstrutura? TipoInfraEst { get; set; }
}

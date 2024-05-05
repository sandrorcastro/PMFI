using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SerIturObjeto
{
    public long ObjId { get; set; }

    public byte[]? Objeto { get; set; }

    public string? ObjetoNome { get; set; }

    public string? ObjetoExt { get; set; }

    public virtual ICollection<SerIturObjetoAtrativosTuristico> SerIturObjetoAtrativosTuristicos { get; set; } = new List<SerIturObjetoAtrativosTuristico>();

    public virtual ICollection<SerIturObjetoDadosEstatistico> SerIturObjetoDadosEstatisticos { get; set; } = new List<SerIturObjetoDadosEstatistico>();

    public virtual ICollection<SerIturObjetoEmpresa> SerIturObjetoEmpresas { get; set; } = new List<SerIturObjetoEmpresa>();

    public virtual ICollection<SeriTurGrupoTipoEstabelecimento> SeriTurGrupoTipoEstabelecimentos { get; set; } = new List<SeriTurGrupoTipoEstabelecimento>();
}

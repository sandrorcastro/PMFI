using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SerIturObjeto
    {
        public SerIturObjeto()
        {
            SerIturObjetoAtrativosTuristicos = new HashSet<SerIturObjetoAtrativosTuristico>();
            SerIturObjetoDadosEstatisticos = new HashSet<SerIturObjetoDadosEstatistico>();
            SerIturObjetoEmpresas = new HashSet<SerIturObjetoEmpresa>();
            SeriTurGrupoTipoEstabelecimentos = new HashSet<SeriTurGrupoTipoEstabelecimento>();
        }

        public long ObjId { get; set; }
        public byte[]? Objeto { get; set; }
        public string? ObjetoNome { get; set; }
        public string? ObjetoExt { get; set; }

        public virtual ICollection<SerIturObjetoAtrativosTuristico> SerIturObjetoAtrativosTuristicos { get; set; }
        public virtual ICollection<SerIturObjetoDadosEstatistico> SerIturObjetoDadosEstatisticos { get; set; }
        public virtual ICollection<SerIturObjetoEmpresa> SerIturObjetoEmpresas { get; set; }
        public virtual ICollection<SeriTurGrupoTipoEstabelecimento> SeriTurGrupoTipoEstabelecimentos { get; set; }
    }
}

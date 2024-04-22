using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SerIturObjetoDadosEstatistico
    {
        public SerIturObjetoDadosEstatistico()
        {
            Atrativos = new HashSet<SerIturAtrativosTuristico>();
        }

        public long DadoEstatisticoId { get; set; }
        public long ObjId { get; set; }
        public string? Descricao { get; set; }
        public DateTime? Data { get; set; }

        public virtual SerIturObjeto Obj { get; set; } = null!;

        public virtual ICollection<SerIturAtrativosTuristico> Atrativos { get; set; }
    }
}

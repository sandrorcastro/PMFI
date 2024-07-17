using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SeriTurOrigemTuristaCidadao
    {
        public SeriTurOrigemTuristaCidadao()
        {
            SeriTurMovAtendimentos = new HashSet<SeriTurMovAtendimento>();
            Idufs = new HashSet<SeriTurUf>();
        }

        public long IdmovOrigem { get; set; }
        public DateTime? Data { get; set; }
        public long? Idpit { get; set; }
        public string UsuId { get; set; } = null!;
        public int? Iduf { get; set; }

        public virtual ICollection<SeriTurMovAtendimento> SeriTurMovAtendimentos { get; set; }

        public virtual ICollection<SeriTurUf> Idufs { get; set; }
    }
}

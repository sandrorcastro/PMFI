using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblTipoTomador
    {
        public NfseTblTipoTomador()
        {
            NfseTblEmpresaTipoTomadores = new HashSet<NfseTblEmpresaTipoTomadore>();
        }

        public int Idtipotomador { get; set; }
        public string Stnome { get; set; } = null!;
        public string Sttipotompadrao { get; set; } = null!;
        public string Stretemiss { get; set; } = null!;
        public string Stsigla { get; set; } = null!;
        public string Stcadcontrib { get; set; } = null!;
        public string? Stnometipodoc { get; set; }
        public string Stdocobrigatorio { get; set; } = null!;
        public string? Stinformacao { get; set; }
        public string? Stdesccamponome { get; set; }

        public virtual ICollection<NfseTblEmpresaTipoTomadore> NfseTblEmpresaTipoTomadores { get; set; }
    }
}

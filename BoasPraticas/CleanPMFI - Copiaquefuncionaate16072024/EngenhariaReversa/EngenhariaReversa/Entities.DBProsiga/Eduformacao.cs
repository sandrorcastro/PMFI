using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Eduformacao
    {
        public Eduformacao()
        {
            EduformacaoContribuintes = new HashSet<EduformacaoContribuinte>();
        }

        public long FormId { get; set; }
        public string? FormNome { get; set; }
        public long? TipoFormId { get; set; }

        public virtual EdutipoFormacao? TipoForm { get; set; }
        public virtual ICollection<EduformacaoContribuinte> EduformacaoContribuintes { get; set; }
    }
}

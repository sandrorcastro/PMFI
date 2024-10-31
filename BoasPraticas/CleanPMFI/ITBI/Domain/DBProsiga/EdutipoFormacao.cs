using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class EdutipoFormacao
    {
        public EdutipoFormacao()
        {
            Eduformacaos = new HashSet<Eduformacao>();
        }

        public long TipoFormId { get; set; }
        public string? TipoFormNome { get; set; }

        public virtual ICollection<Eduformacao> Eduformacaos { get; set; }
    }
}

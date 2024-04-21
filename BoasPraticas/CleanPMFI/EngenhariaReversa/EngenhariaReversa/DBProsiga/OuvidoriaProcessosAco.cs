using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class OuvidoriaProcessosAco
    {
        public long IdouvProcAco { get; set; }
        public long IdouvProcesso { get; set; }
        public DateTime? DataOuvProcAco { get; set; }
        public string? TipoOcorrencia { get; set; }
        public string? DescricaoAco { get; set; }
        public string? Divulga { get; set; }
        public DateTime? DataRetornoContrib { get; set; }
        public string? UsuarioRetornoContrib { get; set; }

        public virtual OuvidoriaProcesso IdouvProcessoNavigation { get; set; } = null!;
    }
}

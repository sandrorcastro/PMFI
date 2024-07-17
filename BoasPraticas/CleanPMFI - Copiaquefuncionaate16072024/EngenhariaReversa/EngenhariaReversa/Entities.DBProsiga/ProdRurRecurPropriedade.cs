using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ProdRurRecurPropriedade
    {
        public int IdrecPropriedade { get; set; }
        public int? Idpropriedade { get; set; }
        public int? IdtipoRecurso { get; set; }
        public int? Qtde { get; set; }
        public DateTime? DataIni { get; set; }
        public DateTime? DataFim { get; set; }

        public virtual ProdRurPropriedade? IdpropriedadeNavigation { get; set; }
        public virtual ProdRurTipoRecurso? IdtipoRecursoNavigation { get; set; }
    }
}

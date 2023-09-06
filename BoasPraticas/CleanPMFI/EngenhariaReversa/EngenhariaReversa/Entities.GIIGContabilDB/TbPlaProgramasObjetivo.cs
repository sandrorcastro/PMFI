using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaProgramasObjetivo
    {
        public int IdObjetivo { get; set; }
        public string? CdObjetivo { get; set; }
        public string? DsObjetivo { get; set; }
        public int? IdPrograma { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbPlaPrograma? IdProgramaNavigation { get; set; }
    }
}

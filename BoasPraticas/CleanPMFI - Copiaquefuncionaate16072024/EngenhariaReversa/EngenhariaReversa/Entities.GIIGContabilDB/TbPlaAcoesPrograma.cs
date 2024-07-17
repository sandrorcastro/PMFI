using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaAcoesPrograma
    {
        public int IdAcao { get; set; }
        public int IdPrograma { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public int? IdVersaoVinculo { get; set; }
        public DateTime? DtVinculo { get; set; }
        public string? DsLoginVinculo { get; set; }
        public int? IdVersaoCancelamento { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public string? DsNotaExplicativa { get; set; }
        public string? DsLoginCancelamento { get; set; }

        public virtual TbPlaAco IdAcaoNavigation { get; set; } = null!;
        public virtual TbPlaPrograma IdProgramaNavigation { get; set; } = null!;
    }
}

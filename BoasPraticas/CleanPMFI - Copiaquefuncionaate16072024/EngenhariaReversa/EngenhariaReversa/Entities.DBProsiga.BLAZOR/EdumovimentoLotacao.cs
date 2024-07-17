using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class EdumovimentoLotacao
    {
        public long MovLotId { get; set; }
        public int? LocId { get; set; }
        public long? DadFid { get; set; }
        public DateTime? MovLotDataMov { get; set; }
        public string? MovLotMotivo { get; set; }
        public string? MovLotTipo { get; set; }
        public string? MovLotTipoMovimento { get; set; }
        public long? CargoFuncId { get; set; }

        public virtual RhcargosFunco? CargoFunc { get; set; }
        public virtual RhdadosFuncionai? DadF { get; set; }
        public virtual Localizacao? Loc { get; set; }
    }
}

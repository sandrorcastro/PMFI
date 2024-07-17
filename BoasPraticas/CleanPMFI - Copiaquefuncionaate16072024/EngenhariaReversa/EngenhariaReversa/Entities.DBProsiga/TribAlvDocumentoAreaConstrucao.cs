using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAlvDocumentoAreaConstrucao
    {
        public int IdDocumentoAreaConstrucao { get; set; }
        public int IdDocumento { get; set; }
        public string DsTipoConstrucao { get; set; } = null!;
        public decimal? NrAreaConstrucao { get; set; }
        public string? DsTipoMaterial { get; set; }
        public string? DsTipoArea { get; set; }
        public string? StUnidadeMedida { get; set; }
        public short? NrUndiadesBloco { get; set; }
        public string? TpAreaComplementar { get; set; }
        public decimal? NrAreaCompCoberta { get; set; }
        public decimal? NrAreaCompAberta { get; set; }

        public virtual TribAlvDocumento IdDocumentoNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPcmRemuneracaoAgentesPolitico
    {
        public int IdAgente { get; set; }
        public short? NrMes { get; set; }
        public DateTime DtPagamento { get; set; }
        public decimal? VlSubsidio { get; set; }
        public decimal? VlAdicionais { get; set; }
        public decimal? VlExtraordinaria { get; set; }
        public decimal? VlDecimoTerceiro { get; set; }
        public decimal? VlImpostoRenda { get; set; }
        public decimal? VlPrevidencia { get; set; }
        public decimal? VlPrevidenciaParticular { get; set; }
        public short? NrDependentes { get; set; }
        public string? FlPago { get; set; }

        public virtual TbPcmAgentesPolitico IdAgenteNavigation { get; set; } = null!;
    }
}

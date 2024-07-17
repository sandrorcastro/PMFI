using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicProcessosAdministrativo
    {
        public TbLicProcessosAdministrativo()
        {
            IdEmpenhos = new HashSet<TbDspEmpenho>();
        }

        public int IdProcAdm { get; set; }
        public short? IdSetorCompra { get; set; }
        public string? NrProcAdm { get; set; }
        public short? IdModalidade { get; set; }
        public short? IdNaturezaProcedimento { get; set; }
        public string? DsProcAdm { get; set; }
        public int? IdRms { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual ICollection<TbDspEmpenho> IdEmpenhos { get; set; }
    }
}

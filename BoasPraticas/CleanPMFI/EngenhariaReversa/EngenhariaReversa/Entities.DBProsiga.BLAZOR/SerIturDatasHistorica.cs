using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SerIturDatasHistorica
    {
        public SerIturDatasHistorica()
        {
            Atrativos = new HashSet<SerIturAtrativosTuristico>();
        }

        public long DataHistId { get; set; }
        public DateTime? DataHistData { get; set; }
        public string? DataHistDescricao { get; set; }

        public virtual ICollection<SerIturAtrativosTuristico> Atrativos { get; set; }
    }
}

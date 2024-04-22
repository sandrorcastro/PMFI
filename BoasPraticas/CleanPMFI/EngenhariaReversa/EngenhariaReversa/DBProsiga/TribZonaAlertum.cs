using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribZonaAlertum
    {
        public int ZoalId { get; set; }
        public long? TerrenoId { get; set; }
        public short? ZomsId { get; set; }
        public string? ZoalComplemento { get; set; }
    }
}

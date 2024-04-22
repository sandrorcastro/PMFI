using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProtestoLoteCdacontrib
    {
        public int IdLoteContrib { get; set; }
        public int? IdLote { get; set; }
        public long? CertidaoDaid { get; set; }
        public long? ConId { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual TribProtestoLoteCdum? TribProtestoLoteCdum { get; set; }
    }
}

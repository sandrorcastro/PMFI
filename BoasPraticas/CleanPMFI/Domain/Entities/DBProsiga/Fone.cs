using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Fone
    {
        public long? FoneId { get; set; }
        public int? FoneTipoId { get; set; }
        public string? FoneDdd { get; set; }
        public string? FonePrefixo { get; set; }
        public string? FoneSeparador { get; set; }
        public string? FoneNumero { get; set; }
    }
}

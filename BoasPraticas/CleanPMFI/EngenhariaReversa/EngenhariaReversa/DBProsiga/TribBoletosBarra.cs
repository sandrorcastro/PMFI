using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribBoletosBarra
    {
        public string Bolenossonumero { get; set; } = null!;
        public byte[]? BoleCodigoBarra { get; set; }
    }
}

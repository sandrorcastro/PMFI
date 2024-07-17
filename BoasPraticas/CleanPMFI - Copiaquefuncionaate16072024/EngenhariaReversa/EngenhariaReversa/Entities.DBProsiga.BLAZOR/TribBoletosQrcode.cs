using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribBoletosQrcode
    {
        public string Bolenossonumero { get; set; } = null!;
        public byte[]? BoleQrcode { get; set; }
    }
}

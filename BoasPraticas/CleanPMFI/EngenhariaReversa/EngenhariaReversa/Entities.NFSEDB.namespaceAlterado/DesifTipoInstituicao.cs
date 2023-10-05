using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class DesifTipoInstituicao
    {
        public string Idtipoinstituicao { get; set; } = null!;
        public string Stdescricao { get; set; } = null!;
        public string Sttarifaobrigatoria { get; set; } = null!;
    }
}

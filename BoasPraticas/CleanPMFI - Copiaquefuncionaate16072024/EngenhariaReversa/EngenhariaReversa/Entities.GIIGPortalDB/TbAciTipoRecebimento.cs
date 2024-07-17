using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbAciTipoRecebimento
    {
        public int IdTipoRecebimento { get; set; }
        public short? CdTipoRecebimento { get; set; }
        public string? DsTipoRecebimento { get; set; }
        public string? FlGeraCusto { get; set; }
        public string? DsObservacoes { get; set; }
    }
}

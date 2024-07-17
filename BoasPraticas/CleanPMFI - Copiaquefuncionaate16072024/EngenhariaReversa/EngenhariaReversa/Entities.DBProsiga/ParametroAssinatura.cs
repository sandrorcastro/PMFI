using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ParametroAssinatura
    {
        public ParametroAssinatura()
        {
            AssinaturasComposicaos = new HashSet<AssinaturasComposicao>();
        }

        public long IdparamAssinatura { get; set; }
        public string? Descricao { get; set; }
        public long IdtipoDoc { get; set; }
        public string? EstadoAgrupamento { get; set; }

        public virtual TiposDocumentosOficiai IdtipoDocNavigation { get; set; } = null!;
        public virtual ICollection<AssinaturasComposicao> AssinaturasComposicaos { get; set; }
    }
}

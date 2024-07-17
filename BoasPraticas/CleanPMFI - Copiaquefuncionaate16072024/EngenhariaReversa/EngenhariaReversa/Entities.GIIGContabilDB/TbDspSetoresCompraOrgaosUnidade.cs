using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspSetoresCompraOrgaosUnidade
    {
        public int IdSetorOrgUnidade { get; set; }
        public short IdSetorCompra { get; set; }
        public short Idempresa { get; set; }
        public short NrAno { get; set; }
        public string CdOrgao { get; set; } = null!;
        public string CdUnidade { get; set; } = null!;
        public bool? FlElaboraProcesso { get; set; }
        public bool? FlVisualizaElaboracaoProcesso { get; set; }

        public virtual TbDspSetoresCompra IdSetorCompraNavigation { get; set; } = null!;
        public virtual TbOrcUnidade TbOrcUnidade { get; set; } = null!;
    }
}

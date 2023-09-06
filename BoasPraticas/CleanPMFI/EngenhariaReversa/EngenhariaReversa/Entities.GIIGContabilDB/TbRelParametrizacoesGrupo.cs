using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRelParametrizacoesGrupo
    {
        public TbRelParametrizacoesGrupo()
        {
            TbRelParametrizacoesDetalhes = new HashSet<TbRelParametrizacoesDetalhe>();
        }

        public int IdGrupo { get; set; }
        public short? IdRelatorio { get; set; }
        public string? NmGrupo { get; set; }
        public string? DsGrupo { get; set; }
        public string? DsTituloDetalhe { get; set; }
        public short? NrColunas { get; set; }
        public short? NrSequencia { get; set; }

        public virtual TbRelParametrizaco? IdRelatorioNavigation { get; set; }
        public virtual ICollection<TbRelParametrizacoesDetalhe> TbRelParametrizacoesDetalhes { get; set; }
    }
}

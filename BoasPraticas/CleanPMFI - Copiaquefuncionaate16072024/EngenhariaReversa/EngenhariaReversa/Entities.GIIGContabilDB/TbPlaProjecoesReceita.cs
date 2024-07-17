using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaProjecoesReceita
    {
        public int IdProjecao { get; set; }
        public short? IdEmpresa { get; set; }
        public int? IdReceita { get; set; }
        public short? IdExecutor { get; set; }
        public int? IdVersaoProjecao { get; set; }
        public short? CdArea { get; set; }
        public decimal? VlEstimado { get; set; }
        public string? DsTpComando { get; set; }
        public short? NrAno { get; set; }
        public short? IdTipoOperacaoReceita { get; set; }

        public virtual TbPlaAreasProjecaoReceitum? CdAreaNavigation { get; set; }
        public virtual TbOrcReceita? IdReceitaNavigation { get; set; }
    }
}

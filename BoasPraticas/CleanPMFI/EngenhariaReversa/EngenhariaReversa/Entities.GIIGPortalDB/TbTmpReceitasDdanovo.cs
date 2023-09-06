using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpReceitasDdanovo
    {
        public int? NrAno { get; set; }
        public int? NrMes { get; set; }
        public int? IdReceita { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? NmUnidade { get; set; }
        public string? CdReceita { get; set; }
        public string? DsReceita { get; set; }
        public decimal? VlOrcado { get; set; }
        public decimal? VlReestimado1 { get; set; }
        public decimal? VlReestimado2 { get; set; }
        public decimal? VlArrecadadoPeriodo { get; set; }
        public decimal? VlArrecadadoMes { get; set; }
        public int? IdReceitaNivelSuper { get; set; }
        public int? Nivel { get; set; }
        public string? Tipo { get; set; }
        public string? Grupo { get; set; }
        public int? IdTipoOperacaoReceita { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGGestorDB
{
    public partial class TbTmpFuncaoSubFuncao
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? Cdfuncao { get; set; }
        public string? Dsfuncao { get; set; }
        public string? Cdsubfuncao { get; set; }
        public string? Dssubfuncao { get; set; }
        public decimal? Vlorcado { get; set; }
        public decimal? Vlatualizado { get; set; }
        public decimal? Vlempenhoperiodo { get; set; }
        public decimal? Vlempenhoateperiodo { get; set; }
        public decimal? Vlliquidadoperiodo { get; set; }
        public decimal? Vlliquidadoateperiodo { get; set; }
    }
}

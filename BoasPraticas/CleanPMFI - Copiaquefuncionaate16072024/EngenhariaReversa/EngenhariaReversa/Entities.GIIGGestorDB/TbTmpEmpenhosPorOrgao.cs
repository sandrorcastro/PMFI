﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGGestorDB
{
    public partial class TbTmpEmpenhosPorOrgao
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? Cdorgao { get; set; }
        public string? Nmorgao { get; set; }
        public decimal? Vlempenhado { get; set; }
    }
}

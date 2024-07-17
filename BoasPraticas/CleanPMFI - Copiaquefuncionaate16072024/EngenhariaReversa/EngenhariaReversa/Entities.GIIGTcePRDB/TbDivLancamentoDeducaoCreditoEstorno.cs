﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbDivLancamentoDeducaoCreditoEstorno
    {
        public int IdDeducaoEstorno { get; set; }
        public int? IdDeducao { get; set; }
        public int? NrEstorno { get; set; }
        public short? NrAnoEstorno { get; set; }
        public int? IdLeitAto { get; set; }
        public DateTime? DtEstorno { get; set; }
        public decimal? VlEstono { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginInclusao { get; set; }

        public virtual TbDivLancamentoDeducaoCredito? IdDeducaoNavigation { get; set; }
        public virtual TbGerLeiAto? IdLeitAtoNavigation { get; set; }
    }
}

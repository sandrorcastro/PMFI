﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribAlvFormula
    {
        public TribAlvFormula()
        {
            TribAlvCalculos = new HashSet<TribAlvCalculo>();
        }

        public short IdFormula { get; set; }
        public string? DsFormula { get; set; }
        public string? VlFormula { get; set; }
        public short? NrFormula { get; set; }
        public short? IdTipoCalculo { get; set; }
        public int? IdTipoBaixaLancamento { get; set; }
        public string? DsTipoMaoObra { get; set; }

        public virtual TribTipoBaixa? IdTipoBaixaLancamentoNavigation { get; set; }
        public virtual TribAlvTipoCalculo? IdTipoCalculoNavigation { get; set; }
        public virtual ICollection<TribAlvCalculo> TribAlvCalculos { get; set; }
    }
}

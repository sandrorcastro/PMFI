﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribFunCriancaDividaContrib
    {
        public long FunCriDivId { get; set; }
        public long ConIddivida { get; set; }
        public string FunCriEntCnpj { get; set; } = null!;
        public string FunCriEntNome { get; set; } = null!;

        public virtual TribDividasContribuinte ConIddividaNavigation { get; set; } = null!;
    }
}

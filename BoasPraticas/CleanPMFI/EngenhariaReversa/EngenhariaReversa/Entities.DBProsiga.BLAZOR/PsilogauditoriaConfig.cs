﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class PsilogauditoriaConfig
    {
        public string LogAuditConfigNomeTabela { get; set; } = null!;
        public string? LogAuditConfigAtivadoIns { get; set; }
        public string? LogAuditConfigAtivadoAlt { get; set; }
        public string? LogAuditConfigAtivadoExc { get; set; }
    }
}
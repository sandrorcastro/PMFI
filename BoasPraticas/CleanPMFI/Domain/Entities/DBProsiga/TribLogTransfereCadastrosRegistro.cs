﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribLogTransfereCadastrosRegistro
    {
        public int IdTransfereCadastrosRegistros { get; set; }
        public int IdLog { get; set; }
        public string NmTabelaAlterada { get; set; } = null!;
        public string VlChaveTabelaAlterada { get; set; } = null!;

        public virtual TribLogTransfereCadastro IdLogNavigation { get; set; } = null!;
    }
}

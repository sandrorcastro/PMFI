using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEdificacoesCancelada
    {
        public int EdifCancId { get; set; }
        public long EdificacaoId { get; set; }
        public DateTime? EdifCancData { get; set; }
        public string? EdifCancMotivo { get; set; }
        public int? EdifCancNumProtocolo { get; set; }
        public short? EdifCancAnoProtocolo { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? EdifCancMotivoReativar { get; set; }
        public DateTime? EdifCancDataReativar { get; set; }
        public string? EdifCancUsuarioReativar { get; set; }

        public virtual TribEdificaco Edificacao { get; set; } = null!;
    }
}

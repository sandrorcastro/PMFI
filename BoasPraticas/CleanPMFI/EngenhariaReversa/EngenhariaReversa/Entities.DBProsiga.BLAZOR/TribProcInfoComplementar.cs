using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribProcInfoComplementar
    {
        public long ProcInfoId { get; set; }
        public long? ProcId { get; set; }
        public int? ProcTipoInfoId { get; set; }
        public DateTime? ProcInfoData { get; set; }
        public string? ProcInfoObs { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? UsuarioAlteracao { get; set; }

        public virtual TribProcProcesso? Proc { get; set; }
        public virtual TribProcTipoInformacao? ProcTipoInfo { get; set; }
    }
}

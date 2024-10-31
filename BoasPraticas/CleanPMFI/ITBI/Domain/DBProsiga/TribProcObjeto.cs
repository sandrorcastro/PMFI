using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProcObjeto
    {
        public int ProcObjId { get; set; }
        public long ProcId { get; set; }
        public int ObjetoId { get; set; }
        public int? TipoObjetoId { get; set; }
        public string? ProcObjNumero { get; set; }
        public string? ProcObjResumo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? UsuarioAlteracao { get; set; }
        public string? TipoRegistro { get; set; }
    }
}

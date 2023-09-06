using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEmpresaAnexo
    {
        public long AnexId { get; set; }
        public long EmprCmc { get; set; }
        public int ProtAltId { get; set; }
        public int ObjetoId { get; set; }
        public string? NomeDoc { get; set; }

        public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
        public virtual TribObjeto Objeto { get; set; } = null!;
        public virtual TribProtocoloAlteracao ProtAlt { get; set; } = null!;
    }
}

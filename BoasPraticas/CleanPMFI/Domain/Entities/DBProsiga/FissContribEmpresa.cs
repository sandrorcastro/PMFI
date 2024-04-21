using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class FissContribEmpresa
    {
        public long ConId { get; set; }
        public long EmprCmc { get; set; }
        public long? ContadorId { get; set; }
        public long? ServId { get; set; }
        public DateTime? FissCedataCad { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
        public virtual TribContador? Contador { get; set; }
        public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
        public virtual Servidore? Serv { get; set; }
    }
}

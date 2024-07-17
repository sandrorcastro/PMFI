using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class VisaoEmpresasComDividasDobrada
    {
        public long? EmprCmc { get; set; }
        public int? TipoTribId { get; set; }
        public int? EmprDivAno { get; set; }
        public int? EmprDivMes { get; set; }
        public int? EmprDivSubDivida { get; set; }
        public int? EmprDivParcela { get; set; }
        public int? Qtde { get; set; }
    }
}

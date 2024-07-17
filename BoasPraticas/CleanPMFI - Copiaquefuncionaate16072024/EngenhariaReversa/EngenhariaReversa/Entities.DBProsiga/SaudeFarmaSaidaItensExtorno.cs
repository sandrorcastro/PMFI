using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeFarmaSaidaItensExtorno
    {
        public long IdItemExtorno { get; set; }
        public string IdentLote { get; set; } = null!;
        public int Idfabricante { get; set; }
        public int Idmedicamento { get; set; }
        public int Idestoque { get; set; }
        public int Qtd { get; set; }
        public int SaldoLote { get; set; }
        public int? SaldoMedicamento { get; set; }
        public int IdReceita { get; set; }
        public DateTime? DtItemMovimento { get; set; }
        public string? HrItemMovimento { get; set; }
        public string? Usuario { get; set; }

        public virtual SaudeMedicamentoXxxxxx IdmedicamentoNavigation { get; set; } = null!;
    }
}
